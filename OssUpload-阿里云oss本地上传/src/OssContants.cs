using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OssUpload.src
{
    class OssContants
    {
        /// <summary>
        /// 在Oss存储的目录
        /// </summary>
        public static Hashtable OSSPATH = new Hashtable();
        static OssContants()
        {
            OSSPATH.Add("测试目录(test)", "test");
            OSSPATH.Add("课程(project)", "project");
            OSSPATH.Add("课程任务(project_task)", "project_task");
            OSSPATH.Add("用户(users)", "users");
            OSSPATH.Add("富文本(reference_resource)", "reference_resource");
            OSSPATH.Add("成果(task_achievement)", "task_achievement");
        }
    }
}
