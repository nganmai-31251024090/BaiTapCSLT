namespace Buoi01_B3
{
internal class Program
{
static void Main(string[] args) //sửa: main -> Main
{
Console.OutputEncoding = System.Text.Encoding.UTF8; //sửa: thêm ;
Console.WriteLine("Chương trình có lỗi"); //sửa: console -> Console, đóng chuỗi
Console.WriteLine("Đường dẫn: C:\\Temp\\new"); //sửa: escape dấu \, dùng chuỗi @, viết hoa WriteLine
Console.WriteLine("Kết thúc"); //sửa: đổi ' thành "
        }
    }
}