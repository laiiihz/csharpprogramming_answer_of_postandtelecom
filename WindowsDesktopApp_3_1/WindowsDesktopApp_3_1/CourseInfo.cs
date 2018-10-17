using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDesktopApp_3_1
{
    class CourseInfo
    {
        
        
        
        private string CourseName;
        private Season CourseTime;
        private string BookName;
        private double Price;

        public string CourseNameTool { get => CourseName; set => CourseName = value; }
        public string BookNameTool { get => BookName; set => BookName = value; }
        public double PriceTool { get => Price; set => Price = value; }
        public Season CourseTimeTool { get => CourseTime; set => CourseTime = value; }

        public CourseInfo(string courseName,Season courseTime,string bookName,double price)
        {
            CourseNameTool=courseName;
            CourseTimeTool = courseTime;
            BookNameTool = bookName;
            PriceTool = price;
            GlobalNums.Counter++;
        }
        public CourseInfo()
        {
            CourseNameTool = "defalut";
            CourseTimeTool = 0;
            BookNameTool = "defalut";
            PriceTool = 0.00;
        }
    }
    
}
