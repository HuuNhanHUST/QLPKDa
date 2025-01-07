using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace frm_login
{
    internal class AccountManager
    {
        // Đường dẫn đến tệp account.txt
        private static string filePath = @"D:\VISUAL STUDIO\QLPKDa\account.txt";

        // Constructor
        public AccountManager()
        {
            // Kiểm tra và tạo thư mục nếu chưa tồn tại
            string directoryPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            // Kiểm tra và tạo tệp nếu chưa tồn tại
            if (!File.Exists(filePath))
            {
                using (var file = File.Create(filePath))
                {
                    file.Close();
                }
            }

            // Tạo tài khoản mặc định nếu chưa tồn tại
            if (!IsAccountExists("anhduc123", filePath))
            {
                CreateAccount("anhduc123", "123456", filePath);
            }
        }

        // Hàm mã hóa mật khẩu bằng SHA-256
        public static string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte byteValue in bytes)
                {
                    builder.Append(byteValue.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        // Hàm kiểm tra tài khoản đã tồn tại hay chưa
        public static bool IsAccountExists(string username, string filePath)
        {
            if (!File.Exists(filePath)) return false;

            string[] accounts = File.ReadAllLines(filePath);
            foreach (var account in accounts)
            {
                string[] accountDetails = account.Split(':');
                if (accountDetails.Length > 0 && accountDetails[0] == username)
                {
                    return true;
                }
            }
            return false;
        }

        // Hàm tạo tài khoản
        public static bool CreateAccount(string username, string password, string filePath)
        {
            try
            {
                if (IsAccountExists(username, filePath))
                {
                    Console.WriteLine("Tài khoản đã tồn tại.");
                    return false;
                }

                string hashedPassword = HashPassword(password);
                string accountInfo = username + ":" + hashedPassword;

                File.AppendAllText(filePath, accountInfo + Environment.NewLine);
                Console.WriteLine("Tài khoản đã được tạo và lưu vào file.");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi khi lưu tài khoản: " + ex.Message);
                return false;
            }
        }

        // Hàm xác thực người dùng
        public static bool AuthenticateUser(string username, string password, string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("File account.txt không tồn tại.");
                    return false;
                }

                string[] accounts = File.ReadAllLines(filePath);
                foreach (var account in accounts)
                {
                    string[] accountDetails = account.Split(':');
                    if (accountDetails.Length != 2) continue;

                    string storedUsername = accountDetails[0];
                    string storedHashedPassword = accountDetails[1];

                    if (storedUsername == username && storedHashedPassword == HashPassword(password))
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Có lỗi khi xác thực người dùng: " + ex.Message);
            }

            return false;
        }
    }
}
