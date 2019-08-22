using System.Collections;
using System.Collections.Generic;
namespace Iterator_Pattern
{
    public class ProjectIterator : IEnumerable
    {
        private List<Project> projectList;
        public ProjectIterator(List<Project> projectList)
        {
            this.projectList = projectList;
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < this.projectList.Count; index++)
            {
                yield return this.projectList[index];
            }
        }
    }
}