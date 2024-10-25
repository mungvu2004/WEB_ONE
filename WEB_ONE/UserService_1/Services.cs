using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WEB_ONE.UserService
{
    public class Services
    {
        private readonly string _connectionString;

        public Services(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Đăng ký người dùng mới
        public async Task<bool> RegisterUserAsync(string username, string email, string password)
        {
            var passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new SqlCommand("INSERT INTO Users (Username, Email, PasswordHash) VALUES (@Username, @Email, @PasswordHash)", connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@PasswordHash", passwordHash);

                try
                {
                    await command.ExecuteNonQueryAsync();
                    return true;
                }
                catch (SqlException ex) when (ex.Number == 2627) // Lỗi trùng lặp khóa
                {
                    return false;
                }
            }
        }

        // Đăng nhập người dùng
        public async Task<bool> LoginUserAsync(string username, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var command = new SqlCommand("SELECT PasswordHash FROM Users WHERE Username = @Username", connection);
                command.Parameters.AddWithValue("@Username", username);

                var passwordHash = (string)await command.ExecuteScalarAsync();
                if (passwordHash == null)
                {
                    return false; // Người dùng không tồn tại
                }

                return BCrypt.Net.BCrypt.Verify(password, passwordHash); // Xác thực mật khẩu
            }
        }
    }
}