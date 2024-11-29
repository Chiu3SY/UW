using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace employee_manage_system_new.Models
{
    //包含员工工号，姓名 ，性别，
    //岗位（开发工程师，装配技术员，项目工程师，采购员，财务，人事），
    //级别（初级，中级，高级，经理），
    //入职时间，出生时间，籍贯，薪资等
    public class IncomeInfo
    {
        //员工工号
        public int Id { get; set; }
        //姓名
        public string Name { get; set; }
        //性别
        public string Gender { get; set; }
        //岗位
        public string Job { get; set; }
        //级别
        public string Level {  get; set; }  
        //入职时间
        public DateTime Dateofentry {  get; set; }
        //出生时间
        public DateTime Birth { get; set; } 
        //籍贯
        public string Nationality { get; set;} 
        //薪资
        public decimal Salary { get; set;} = 0;


    }
}
