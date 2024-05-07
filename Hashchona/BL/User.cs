using Hashchona.DAL;

namespace Hashchona.BL
{
    public class User
    {
        int userId;
        string firstName;
        string lastName;
        string phoneNum;
        string password;
        char gender;
        string city;
        string street;
        int homeNum;
        DateTime birthDate;
        string discription;        
        //profile picture;
        int score;
        double rating;
        char isActive;

        List<Community> communiyList = new List<Community>();

        public int UserId { get => userId; set => userId = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNum { get => phoneNum; set => phoneNum = value; }
        public string Password { get => password; set => password = value; }
        public char Gender { get => gender; set => gender = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public int HomeNum { get => homeNum; set => homeNum = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Discription { get => discription; set => discription = value; }
        public int Score { get => score; set => score = value; }
        public double Rating { get => rating; set => rating = value; }
        public char IsActive { get => isActive; set => isActive = value; }
        public List<Community> CommuniyList { get => communiyList; set => communiyList = value; }

        public User() { }

        public User(int userId, string firstName, string lastName, string phoneNum, string password, char gender, string city, string street,
                    int homeNum, DateTime birthDate, string discription, int score, double rating, char isActive , List<Community> communiyList)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNum = phoneNum;
            Password = password;
            Gender = gender;
            City = city;
            Street = street;
            HomeNum = homeNum;
            BirthDate = birthDate;
            Discription = discription;
            Score = score;
            Rating = rating;
            IsActive = isActive;
            CommuniyList = communiyList;

        }



        //Insert new user
        public int Insert(int communityID)
        {
            DBservices db = new DBservices();
            return db.InsertUser(this, communityID);
        }

        //Read all users
        public List<User> ReadAllUsers() 
        {
            DBservices db = new DBservices();

            return db.ReadAllUsers(); 
        }
        public User ReadUser(string phoneNum) 
        {
            DBservices db = new DBservices();

            return db.ReadUser(phoneNum); 
        }

        //Update user deatils
        public int UpdateUserDetails() 
        {
            DBservices db = new DBservices();
            return db.UpdateUserDetails(this);
        }
        //Delete user
        public int DeleteForGood(string phoneNum) 
        { 
            DBservices dB = new DBservices();
            return dB.DeleteUser(phoneNum); 
        }

        //Add user to community, the admin is approve the new user to enter the community
        public int addUserToCommunity()
        {
            DBservices db = new DBservices();
            return 1;
        }

        //Remove user from community
        public int removeFromCommmunity()
        {
            DBservices db = new DBservices();
            return 1;
        }
        //Login to community
        public User Login(string phoneNum, string password, int communityId)
        {
            DBservices db = new DBservices();
            return db.Login(phoneNum, password, communityId);
        }

        //Login to community
        //public string Login(string phoneNum, string password, int communityId)
        //{
        //    DBservices db = new DBservices();
        //    return db.Login(phoneNum, password, communityId);
        //}

        //Update User Approval Status
        public int UpdateUserApprovalStatus(int userId, int communityId, string approvalStatus) 
        {
            DBservices db = new DBservices();
           int NumEffected =  db.UpdateUserApprovalStatus(userId, communityId, approvalStatus);

            if (approvalStatus == "Approved")
            {
                Community community = new Community();
                community = db.ReadSpecificCommunity(communityId);
                communiyList.Add(community);
            }

            return NumEffected; 
        }    

      

       
        
    }

    public class UserLogin
    {
    
        public int CommunityID { get; set; }
        public string PhoneNum { get; set; }
        public string Password { get; set; }

    }
}
