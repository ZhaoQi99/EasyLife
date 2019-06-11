using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLife.BLL
{
    public class PhoneBook
    {
        private readonly DAL.PhoneBook dal = new DAL.PhoneBook();
        public DataSet GetList(string Department, string campus,string SecondDepartment)
        {
            StringBuilder strWhere = new StringBuilder();
            bool flag = false;
            if(Department!=string.Empty)
            {
                strWhere.Append("Department='" + Department + "' ");
                flag = true;
            }
            if(campus!=string.Empty)
            {
                if (flag == true)
                    strWhere.Append("AND Campus='" + campus + "' ");
                else
                    strWhere.Append("Campus='" + campus + "' ");
                flag = true;
            }
            if (SecondDepartment != string.Empty)
            {
                if (flag == true)
                    strWhere.Append("AND SecondDepartment='" + SecondDepartment + "' ");
                else
                    strWhere.Append("SecondDepartment='" + SecondDepartment + "' ");
            }
            return dal.Query(strWhere.ToString());
        }
        public string[] QueryDep()
        {
            return dal.QueryDep();
        }
        public int Delete(string Department, string campus, string SecondDepartment)
        {
            StringBuilder strWhere = new StringBuilder();
            bool flag = false;
            if (Department != string.Empty)
            {
                strWhere.Append("Department='" + Department + "' ");
                flag = true;
            }
            if (campus != string.Empty)
            {
                if (flag == true)
                    strWhere.Append("AND Campus='" + campus + "' ");
                else
                    strWhere.Append("Campus='" + campus + "' ");
                flag = true;
            }
            if (SecondDepartment != string.Empty)
            {
                if (flag == true)
                    strWhere.Append("AND SecondDepartment='" + SecondDepartment + "' ");
                else
                    strWhere.Append("Campus='" + SecondDepartment + "' ");
            }
            return dal.Delete(strWhere.ToString());
        }
        public int Add(string department,string telnumber,string seconddepartment,string campus)
        {
            Model.PhoneBook model = new Model.PhoneBook();
            model.Department = department;
            model.SecondDepartment = seconddepartment;
            model.Campus = campus;
            model.TelNumber = telnumber;
            return dal.Add(model);
        }
    }
}
