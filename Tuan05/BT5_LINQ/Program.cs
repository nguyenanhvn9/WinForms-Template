using System;
using System.Collections.Generic;
using System.Linq;

namespace BT5_LINQ
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
        public double GPA { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }

    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }

    class Program
    {
        static List<Student> studentList;
        static List<Product> productList;
        static List<Course> courseList;
        static List<Enrollment> enrollmentList;

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            InitializeData();

            // Bài 1: Lọc sinh viên có GPA > 8.0
            var topStudents = studentList.Where(s => s.GPA > 8.0);
            Console.WriteLine("\n📘 Bài 1:  Lọc sinh viên có GPA > 8.0");


            Console.WriteLine("Sinh viên có GPA > 8.0:");
            foreach (var student in topStudents)
                Console.WriteLine($"- {student.Name}: GPA = {student.GPA}");

            // Bài 2: Chuyên ngành CNTT và GPA > 9.0
            var excellentCNTTStudents = studentList
                .Where(s => s.Major == "CNTT" && s.GPA > 9.0);
            Console.WriteLine("bai2");

            Console.WriteLine("\n📘 Bài 2: Chuyên ngành CNTT và GPA > 9.0");
            Console.WriteLine("\nSinh viên CNTT có GPA > 9.0:");
            foreach (var student in excellentCNTTStudents)
                Console.WriteLine($"- {student.Name}");

            // Bài 3: Tên sản phẩm
            var productNames = productList.Select(p => p.Name);
            Console.WriteLine("\n📘 Bài 3: Tên sản phẩm");


            Console.WriteLine("\nTên sản phẩm:");
            foreach (var name in productNames)
                Console.WriteLine($"- {name}");

            // Bài 4: 
            var studentsAbove20 = studentList
            .Where(s => s.Age > 20)
             .Select(s => s.Name);
            Console.WriteLine("\n📘 Bài 4");

            Console.WriteLine(" Tên các sinh viên có tuổi lớn hơn 20:");
            foreach (var name in studentsAbove20)
            {
                Console.WriteLine($"- {name}");
            }

            // Bài 5: Tên và giá sản phẩm
            // Sắp xếp theo giá tăng dần
            var sortedProductsAsc = productList.OrderBy(p => p.Price);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n📘 Bài 5: Sắp xếp danh sách sản phẩm");
            Console.WriteLine("\n📦 Sản phẩm sắp xếp theo giá tăng dần:");
            Console.WriteLine("--------------------------------------");
            Console.ResetColor();

            foreach (var product in sortedProductsAsc)
            {
                Console.WriteLine($"✅ {product.Name,-20} - Giá: {product.Price:N0} VND");
            }
            // Sắp xếp theo giá giảm dần
            var sortedProductsDesc = productList.OrderByDescending(p => p.Price);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n📦 Sản phẩm sắp xếp theo giá giảm dần:");
            Console.WriteLine("----------------------------------------");
            Console.ResetColor();

            foreach (var product in sortedProductsDesc)
            {
                Console.WriteLine($"🔽 {product.Name,-20} - Giá: {product.Price:N0} VND");
            }
            //bai6 Các toán tử tổng hợp (Sum, Average, Count, Max, Min)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 6: CÁC TOÁN TỬ TỔNG HỢP - CHƯƠNG II");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // 1. Tổng số lượng tồn kho Electronics
            var totalStockElectronics = productList
                .Where(p => p.Category == "Electronics")
                .Sum(p => p.Stock);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"📦 Tổng số lượng tồn kho Electronics: {totalStockElectronics}");
            Console.ResetColor();

            // 2. GPA trung bình của sinh viên
            var averageGPA = studentList.Average(s => s.GPA);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"🎓 GPA trung bình của sinh viên: {averageGPA:N2}");
            Console.ResetColor();

            // 3. Đếm sinh viên tuổi 20
            var countAge20 = studentList.Count(s => s.Age == 20);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"👥 Số lượng sinh viên tuổi 20: {countAge20}");
            Console.ResetColor();

            // 4. Sản phẩm có giá cao nhất
            var mostExpensiveProduct = productList
                .OrderByDescending(p => p.Price)
                .First();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"💰 Sản phẩm giá cao nhất: {mostExpensiveProduct.Name} - {mostExpensiveProduct.Price:N0} VND");
            Console.ResetColor();

            //bài 7.Kiểm tra sự tồn tại (Any, All)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 7: KIỂM TRA SỰ TỒN TẠI - CHƯƠNG II");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // 1. Kiểm tra có sinh viên nào thuộc ngành "An toàn thông tin"
            bool hasSecurityStudent = studentList.Any(s => s.Major == "An toàn thông tin");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"🔍 Có sinh viên ngành 'An toàn thông tin'? => {(hasSecurityStudent ? "Có" : "Không")}");
            Console.ResetColor();

            // 2. Kiểm tra tất cả sản phẩm có giá > 100,000 VNĐ
            bool allProductsAbove100k = productList.All(p => p.Price > 100000);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"💰 Tất cả sản phẩm đều có giá > 100,000 VNĐ? => {(allProductsAbove100k ? "Đúng" : "Sai")}");
            Console.ResetColor();

            // Bài 8: Lấy phần tử đơn (First, FirstOrDefault, Single, SingleOrDefault)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 8: LẤY PHẦN TỬ ĐƠN - CHƯƠNG II");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // 1. Tìm sinh viên đầu tiên có GPA > 9.0
            var firstHighGPAStudent = studentList.FirstOrDefault(s => s.GPA > 9.0);

            if (firstHighGPAStudent != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"🎯 Sinh viên đầu tiên có GPA > 9.0:");
                Console.WriteLine($"👨‍🎓 {firstHighGPAStudent.Name} - GPA: {firstHighGPAStudent.GPA:N1}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Không có sinh viên nào có GPA > 9.0.");
            }
            Console.ResetColor();

            // 2. Tìm sinh viên duy nhất có ID = 3
            var studentId3 = studentList.SingleOrDefault(s => s.Id == 3);

            if (studentId3 != null)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n🆔 Sinh viên có ID = 3:");
                Console.WriteLine($"👤 {studentId3.Name} - Tuổi: {studentId3.Age} - Ngành: {studentId3.Major}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n⚠️ Không tìm thấy sinh viên có ID = 3.");
            }
            Console.ResetColor();

            // Bài 9: Nhóm dữ liệu (GroupBy)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 9: GOM NHÓM SINH VIÊN THEO CHUYÊN NGÀNH");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            var groupedByMajor = studentList.GroupBy(s => s.Major);

            foreach (var group in groupedByMajor)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n📚 Ngành: {group.Key}");
                Console.WriteLine("-----------------------------------");
                Console.ResetColor();

                foreach (var student in group)
                {
                    Console.WriteLine($"👨‍🎓 {student.Name} - Tuổi: {student.Age} - GPA: {student.GPA:N1}");
                }
            }

            // bài 10 Gom nhóm và tính toán

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 10: GOM NHÓM VÀ TÍNH TOÁN - CHƯƠNG III");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // Gom nhóm theo Category và tính tổng giá trị tồn kho mỗi nhóm
            var totalStockValuePerCategory = productList
                .GroupBy(p => p.Category)
                .Select(group => new
                {
                    Category = group.Key,
                    TotalValue = group.Sum(p => p.Price * p.Stock)
                });

            foreach (var item in totalStockValuePerCategory)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n📦 Danh mục: {item.Category}");
                Console.ResetColor();
                Console.WriteLine($"💰 Tổng giá trị tồn kho: {item.TotalValue:N0} VND");
            }
            // bài 11: Kết hợp hai danh sách (Join)
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 11: KẾT HỢP DỮ LIỆU - CHƯƠNG III");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // Kết hợp ba danh sách: studentList, enrollmentList, courseList
            var studentCourseJoin = studentList
                .Join(enrollmentList,
                    student => student.Id,
                    enroll => enroll.StudentId,
                    (student, enroll) => new { student, enroll })
                .Join(courseList,
                    se => se.enroll.CourseId,
                    course => course.CourseId,
                    (se, course) => new
                    {
                        StudentName = se.student.Name,
                        CourseName = course.CourseName
                    });

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n📋 Danh sách sinh viên và khóa học đã đăng ký:");
            Console.WriteLine("----------------------------------------------");
            Console.ResetColor();

            foreach (var item in studentCourseJoin)
            {
                Console.WriteLine($"👨‍🎓 {item.StudentName,-25} 📘 {item.CourseName}");
            }
            //Bài 12: Phân trang dữ liệu (Skip, Take)

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 12: PHÂN TRANG DỮ LIỆU - CHƯƠNG IV");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // Sắp xếp sản phẩm theo tên và lấy 2 sản phẩm ở trang thứ 2 (bỏ qua 2 sản phẩm đầu)
            var page2Products = productList
                .OrderBy(p => p.Name)
                .Skip(2)
                .Take(2);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n📄 2 sản phẩm ở trang thứ 2:");
            Console.WriteLine("------------------------------");
            Console.ResetColor();

            foreach (var product in page2Products)
            {
                Console.WriteLine($"🛒 {product.Name,-20} - Giá: {product.Price:N0} VND");
            }

            //Bài 13: Truy vấn phức hợp
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n═════════════════════════════════════════════════");
            Console.WriteLine("📘 BÀI 13: TRUY VẤN PHỨC HỢP - CHƯƠNG IV");
            Console.WriteLine("═════════════════════════════════════════════════");
            Console.ResetColor();

            // Tìm chuyên ngành có GPA trung bình cao nhất
            var topMajor = studentList
                .GroupBy(s => s.Major)
                .Select(g => new
                {
                    Major = g.Key,
                    AvgGpa = g.Average(s => s.GPA)
                })
                .OrderByDescending(x => x.AvgGpa)
                .First();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n🎓 Chuyên ngành có GPA trung bình cao nhất:");
            Console.WriteLine($"📌 Ngành: {topMajor.Major} - GPA TB: {topMajor.AvgGpa:N2}");
            Console.ResetColor();

        }

        static void InitializeData()
        {
            studentList = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyên Văn An", Age = 20, Major = "CNTT", GPA = 8.5 },
                new Student { Id = 2, Name = "Trần Thị Bình", Age = 21, Major = "KTPM", GPA = 7.9 },
                new Student { Id = 3, Name = "Lê Văn Cường", Age = 20, Major = "CNTT", GPA = 9.1 },
                new Student { Id = 4, Name = "Phạm Thị Dung", Age = 22, Major = "HTTT", GPA = 6.8 },
                new Student { Id = 5, Name = "Hoàng Văn Em", Age = 21, Major = "KTPM", GPA = 8.2 }
            };

            productList = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop Dell", Category = "Electronics", Price = 20000000, Stock = 50 },
                new Product { Id = 2, Name = "Bàn phím cơ", Category = "Electronics", Price = 1500000, Stock = 100 },
                new Product { Id = 3, Name = "Sách Lập trình C#", Category = "Books", Price = 250000, Stock = 200 },
                new Product { Id = 4, Name = "Chuột Logitech", Category = "Electronics", Price = 800000, Stock = 150 },
                new Product { Id = 5, Name = "Sách CSDL", Category = "Books", Price = 200000, Stock = 180 }
            };

            courseList = new List<Course>
            {
                new Course { CourseId = 101, CourseName = "Lập trình C#" },
                new Course { CourseId = 102, CourseName = "Cơ sở dữ liệu" }
            };

            enrollmentList = new List<Enrollment>
            {
                new Enrollment { StudentId = 1, CourseId = 101 },
                new Enrollment { StudentId = 1, CourseId = 102 },
                new Enrollment { StudentId = 2, CourseId = 101 },
                new Enrollment { StudentId = 3, CourseId = 102 }
            };
        }
    }
}