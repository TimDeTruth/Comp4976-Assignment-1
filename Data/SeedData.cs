using Microsoft.EntityFrameworkCore;
using Models;

namespace Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            GetUsers()
        );
        modelBuilder.Entity<Resolution>().HasData(
            GetResolutions()
        );
    }

    public static List<User> GetUsers()
    {
        List<User> UserList = new List<User>(){
            new User(){
                UserId = 0,
                Role = User.UserRole.Admin,
                Username = "Admin"
            },
            new User(){
                UserId = 1,
                Role = User.UserRole.BoardMember,
                Username = "User1"
            },
            new User(){
                UserId = 2,
                Role = User.UserRole.BoardMember,
                Username = "User2"
            },
            new User(){
                UserId = 3,
                Role = User.UserRole.BoardMember,
                Username = "User3"
            },

            new User(){
                UserId = 4,
                Role = User.UserRole.BoardMember,
                Username = "User4"
            },

            new User(){
                UserId = 5,
                Role = User.UserRole.BoardMember,
                Username = "User5"
            },
        };

        return UserList;
    }

    public static List<Resolution> GetResolutions()
    {

        List<Resolution> resolutionList = new List<Resolution>(){

            new Resolution(){
                ResolutionId = "1",
                CreationDate = "2021-01-01",
                Abstract = "Resolution 1",
                resolutionStatus = Resolution.Status.accpeted,
                UserId = 1
            },
            new Resolution(){
                ResolutionId = "2",
                CreationDate = "2021-01-01",
                Abstract = "Resolution 2",
                resolutionStatus = Resolution.Status.rejected,
                UserId = 2
            },

            new Resolution(){
                ResolutionId = "3",
                CreationDate = "2021-01-01",
                Abstract = "Resolution 3",
                resolutionStatus = Resolution.Status.draft,
                UserId = 3
            },

            new Resolution(){
                ResolutionId = "4",
                CreationDate = "2021-01-01",
                Abstract = "Resolution 4",
                resolutionStatus = Resolution.Status.incomplete,
                UserId = 4
            },
            };
        return resolutionList;

    }
}