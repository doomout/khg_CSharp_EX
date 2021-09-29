using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Excuse_Manager
{
    class Excuse
    {
        //변명 내용 
        public string  Description { get; set; }
        
        //결과 내용
        public string Results { get; set; }

        //파일 생성일
        public DateTime LastUsed { get; set; }

        //변명거리 입력 받는 경로 필드
        public string ExcusePath { get; set; }

        //폼이 처음 로드 될 때의 생성자
        public Excuse()
        {
            ExcusePath = "";
        }
        //파일을 열었을 때의 생성자
        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }
        //랜덤 변명 버튼을 위한 생성자
        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }
        private void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }
        public void Save(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }
    }
}
