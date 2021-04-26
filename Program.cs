using System;
using System.IO;

namespace ReadWriteExt
{
    class Program
    {
        //const string fileName = "StudentInfo.std";
        const string fileName = "numbers.num";
        static void Main(string[] args)
        {
            int[] numbers = { 122, 51, 516, 56, 16, 5, 4, 2, 4, 21, 5, };
            WriteDefaultValuesFromList(numbers);
            DisplayValuesFromList();
           /* WriteDefaultValues();
            DisplayValues();*/
        }
        public static void WriteDefaultValuesFromList(int[] numbers)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(1221);
                writer.Write(numbers.Length);

                foreach (var num in numbers)
                {
                    writer.Write(num);
                }

            }
        }
        public static void DisplayValuesFromList()
        {
            int MagicNumber;
            int length;


            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    MagicNumber = reader.ReadInt32();
                    if (MagicNumber == 1221)
                    {
                        length = reader.ReadInt32();

                        for (int i = 0; i < length; i++)
                        {
                            Console.WriteLine(reader.ReadInt32());
                        }
                    }
                }

                
            }
        }
        public static void WriteDefaultValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(111);

                writer.Write(1124);
                writer.Write(@"Abdulaziz");
                writer.Write(100);

            }
        }
        public static void DisplayValues()
        {
            int MagicNumber;
            string StudentName;
            int StudentID;
            int marks;

            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    MagicNumber = reader.ReadInt32();
                    StudentID = reader.ReadInt32();
                    StudentName = reader.ReadString();
                    marks = reader.ReadInt32();
                }

                Console.WriteLine("Magic number: " + MagicNumber);
                Console.WriteLine("Student id: " + StudentID);
                Console.WriteLine("Student name: " + StudentName);
                Console.WriteLine("Student marks: " + marks);
            }
        }
    }
}
