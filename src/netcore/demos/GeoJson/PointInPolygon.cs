using System;
using System.Linq;
using System.Collections.Generic;

namespace GeoJson
{
    public static class PointInPolygon
    {

        // c# 版本
        public static bool IsInPolygon(this List<List<float>> poly, List<float> point)
        {
            var coef = poly.Skip(1).Select((p, i) =>
                                            (point[1] - poly[i][1]) * (p[0] - poly[i][0])
                                          - (point[0] - poly[i][0]) * (p[1] - poly[i][1]));

            var coefNum = coef.GetEnumerator();

            if (coef.Any(p => p == 0))
                return true;

            float lastCoef = coefNum.Current;
            int count = coef.Count();

            coefNum.MoveNext();

            do
            {
                Console.WriteLine($"Current:{coefNum.Current}, lastCoef:{lastCoef}");
                if (coefNum.Current * lastCoef < 0)
                    return false;

                lastCoef = coefNum.Current;
            }
            while (coefNum.MoveNext());

            return true;
        }

        /// <summary>
        /// 确定给定点是否在多边形内
        /// </summary>
        /// <param name="polygon">多边形的顶点</param>
        /// <param name="point">给定的点</param>
        /// <returns>在内部为真，否则假</returns>
        public static bool IsPointInPolygon(this List<List<float>> polygon, List<float> point)
        {
            bool result = false;
            int j = polygon.Count() - 1;
            for (int i = 0; i < polygon.Count(); i++)
            {
                // 相交
                if ((polygon[i][1] < point[1] && polygon[j][1] >= point[1]) || (polygon[j][1] < point[1] && polygon[i][1] >= point[1]))
                {
                    // 判断被测点 在 射线与边交点 的左边（X更小）
                    if (polygon[i][0] + (point[1] - polygon[i][1]) / (polygon[j][1] - polygon[i][1]) * (polygon[j][0] - polygon[i][0]) < point[0])
                    {
                        result = !result;
                    }
                }
                j = i;
            }
            return result;
        }
    }
}