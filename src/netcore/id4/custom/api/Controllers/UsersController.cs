using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using api.Models;
using System.Net.Http;
using IdentityModel.Client;

namespace api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly HttpClient _httpClient;
        public UsersController(IHttpClientFactory clientFactory)
        {
            _httpClient = clientFactory.CreateClient();
        }


        [HttpPost]
        public async Task<ActionResult<UserToken>> Login([FromBody]UserModel user)
        {
            var disco = await _httpClient.GetDiscoveryDocumentAsync("http://localhost:5000");
            if (disco.IsError)
                return BadRequest();

            var response = await _httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
            {
                Address = disco.TokenEndpoint,
                ClientId = "ro.client",
                ClientSecret = "secret",
                UserName = user.userName,
                GrantType = "password",
                Password = user.password
            });

            if (response.IsError)
                return BadRequest();

            return new UserToken
            {
                accessToken = response.AccessToken,
                expiresIn = response.ExpiresIn,
                tokenType = response.TokenType
            };
        }

    }
}
