using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.BLL
{
    public class User
    {
        private readonly DAL. User dal= new DAL.User();
        /// <summary>
        /// 是否存在该用户
        /// </summary>
        public bool Exists(string username)
        {
            return dal.Exists(username);
        }
        /// <summary>
        /// 校验用户名和密码
        /// </summary>
        public bool Check(string username,string password)
        {
            return dal.Check(username,password);
        }
        /// <summary>
        /// 添加一个用户
        /// </summary>
        public void Add(EasyLife.Model.User model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新用户数据
        /// </summary>
        public void Update(EasyLife.Model.User model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        public void Delete(string username)
        {

            dal.Delete(username);
        }

        /// <summary>
        /// 得到一个用户对象实体
        /// </summary>
        public EasyLife.Model.User GetModel(string username)
        {

            return dal.GetModel(username);
        }
        /// <summary>
        /// 检验用户名和密码
        /// </summary>
        public bool CheckForget(string username, string ForPwdQue, string ForPwdAns)
        {
            return dal.CheckForget(username, ForPwdQue, ForPwdAns);
        }

    }
}
