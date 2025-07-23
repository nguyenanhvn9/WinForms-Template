using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // ==== DỮ LIỆU MẪU ====

            var studentList = new List<SinhVien>
            {
                new SinhVien{ ID=1, HoTen="An", Nganh="CNTT", GPA=9.5, Tuoi=21 },
                new SinhVien{ ID=2, HoTen="Bình", Nganh="Kinh tế", GPA=8.2, Tuoi=20 },
                new SinhVien{ ID=3, HoTen="Cường", Nganh="CNTT", GPA=7.9, Tuoi=22 },
                new SinhVien{ ID=4, HoTen="Dương", Nganh="An toàn thông tin", GPA=9.1, Tuoi=20 }
            };

            var productList = new List<Product>
            {
                new Product{ Name="Laptop", Category="Electronics", Price=15000000, Stock=5 },
                new Product{ Name="Phone", Category="Electronics", Price=10000000, Stock=10 },
                new Product{ Name="Book", Category="Stationery", Price=100000, Stock=50 },
                new Product{ Name="Pen", Category="Stationery", Price=5000, Stock=200 }
            };

            var courseList = new List<Course>
            {
                new Course{ CourseID=1, CourseName="C# cơ bản" },
                new Course{ CourseID=2, CourseName="Lập trình Web" }
            };

            var enrollmentList = new List<Enrollment>
            {
                new Enrollment{ StudentID=1, CourseID=1 },
                new Enrollment{ StudentID=2, CourseID=2 },
                new Enrollment{ StudentID=1, CourseID=2 }
            };

            // ==== PHẦN 1: WHERE, SELECT, ORDER ====

            Console.WriteLine("Bài 1: Sinh viên có GPA > 8.0");
            var ketQua1 = studentList.Where(s => s.GPA > 8.0);
            foreach (var sv in ketQua1)
                Console.WriteLine($"- {sv.HoTen} ({sv.GPA})");

            Console.WriteLine("\nBài 2: Sinh viên ngành CNTT GPA > 9.0");
            var ketQua2 = studentList.Where(s => s.Nganh == "CNTT" && s.GPA > 9.0);
            foreach (var sv in ketQua2)
                Console.WriteLine($"- {sv.HoTen}");

            Console.WriteLine("\nBài 3: Tên các sản phẩm");
            var ketQua3 = productList.Select(p => p.Name);
            foreach (var ten in ketQua3)
                Console.WriteLine("- " + ten);

            Console.WriteLine("\nBài 4: Sinh viên tuổi > 20");
            var ketQua4 = studentList.Where(s => s.Tuoi > 20).Select(s => s.HoTen);
            foreach (var ten in ketQua4)
                Console.WriteLine("- " + ten);

            Console.WriteLine("\nBài 5a: Sản phẩm giá tăng dần");
            var tangDan = productList.OrderBy(p => p.Price);
            foreach (var p in tangDan)
                Console.WriteLine($"{p.Name} - {p.Price}");

            Console.WriteLine("\nBài 5b: Sản phẩm giá giảm dần");
            var giamDan = productList.OrderByDescending(p => p.Price);
            foreach (var p in giamDan)
                Console.WriteLine($"{p.Name} - {p.Price}");

            // ==== PHẦN 2: SUM, COUNT, MAX, MIN ====

            Console.WriteLine("\nBài 6.1: Tổng tồn kho Electronics");
            var tongTonKho = productList.Where(p => p.Category == "Electronics").Sum(p => p.Stock);
            Console.WriteLine($"Tổng tồn kho: {tongTonKho}");

            Console.WriteLine("\nBài 6.2: GPA trung bình");
            Console.WriteLine("GPA TB: " + studentList.Average(s => s.GPA));

            Console.WriteLine("\nBài 6.3: Số SV tuổi = 20");
            Console.WriteLine("Số lượng: " + studentList.Count(s => s.Tuoi == 20));

            Console.WriteLine("\nBài 6.4: Sản phẩm giá cao nhất");
            var maxProduct = productList.OrderByDescending(p => p.Price).First();
            Console.WriteLine($"{maxProduct.Name} - {maxProduct.Price}");

            // ==== PHẦN 2.2: ANY, ALL ====

            Console.WriteLine("\nBài 7.1: Có sinh viên ATTT?");
            Console.WriteLine(studentList.Any(s => s.Nganh == "An toàn thông tin"));

            Console.WriteLine("\nBài 7.2: Tất cả sp > 100.000?");
            Console.WriteLine(productList.All(p => p.Price > 100000));

            // ==== PHẦN 2.3: First, Single ====

            Console.WriteLine("\nBài 8.1: SV đầu tiên GPA > 9.0");
            var firstGPA = studentList.FirstOrDefault(s => s.GPA > 9.0);
            Console.WriteLine(firstGPA?.HoTen);

            Console.WriteLine("\nBài 8.2: SV có ID = 3");
            var sv3 = studentList.SingleOrDefault(s => s.ID == 3);
            Console.WriteLine(sv3?.HoTen);

            // ==== PHẦN 3: GROUPBY & JOIN ====

            Console.WriteLine("\nBài 9: Gom nhóm SV theo ngành");
            var groupByMajor = studentList.GroupBy(s => s.Nganh);
            foreach (var group in groupByMajor)
            {
                Console.WriteLine($"Ngành: {group.Key}");
                foreach (var sv in group)
                    Console.WriteLine($" - {sv.HoTen}");
            }

            Console.WriteLine("\nBài 10: Tổng giá trị tồn kho theo danh mục");
            var groupCategory = productList
                .GroupBy(p => p.Category)
                .Select(g => new {
                    DanhMuc = g.Key,
                    TongGiaTri = g.Sum(p => p.Price * p.Stock)
                });
            foreach (var g in groupCategory)
                Console.WriteLine($"{g.DanhMuc}: {g.TongGiaTri}");

            Console.WriteLine("\nBài 11: Danh sách SV và tên khóa học đã đăng ký");
            var joinResult = from e in enrollmentList
                             join s in studentList on e.StudentID equals s.ID
                             join c in courseList on e.CourseID equals c.CourseID
                             select new { s.HoTen, c.CourseName };
            foreach (var item in joinResult)
                Console.WriteLine($"{item.HoTen} - {item.CourseName}");

            // ==== PHẦN 4: PHÂN TRANG & TRUY VẤN NÂNG CAO ====

            Console.WriteLine("\nBài 12: Lấy 2 sản phẩm ở trang 2");
            var page2 = productList.OrderBy(p => p.Name).Skip(2).Take(2);
            foreach (var p in page2)
                Console.WriteLine($"{p.Name}");

            Console.WriteLine("\nBài 13: Ngành có GPA trung bình cao nhất");
            var topMajor = studentList
                .GroupBy(s => s.Nganh)
                .Select(g => new { Nganh = g.Key, AvgGPA = g.Average(s => s.GPA) })
                .OrderByDescending(x => x.AvgGPA)
                .First();
            Console.WriteLine(topMajor.Nganh);

            Console.ReadLine();
        }
    }
}
