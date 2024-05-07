using Hashchona.DAL;

namespace Hashchona.BL
{
    public class Community
    {
        int communityId;
        string name;
        string city;
        string location;
        string discription;
        string primaryPic;
        List<User> managers = new List<User>();
        public int CommunityId { get => communityId; set => communityId = value; }
        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Location { get => location; set => location = value; }
        public string Discription { get => discription; set => discription = value; }
        public string PrimaryPic { get => primaryPic; set => primaryPic = value; }
        public List<User> Managers { get => managers; set => managers = value; }

        public Community() { }

        public Community(int communityId, string name, string city, string location, string discription, string primaryPic, List<User> managers)
        {
            CommunityId = communityId;
            Name = name;
            City = city;
            Location = location;
            Discription = discription;
            PrimaryPic = primaryPic;            
            Managers = managers;
        }

        //Read all communitis list
        public List<Community> ReadAllCommunitis()
        {
            DBservices db = new DBservices();

            return db.ReadAllCommunitis();
        }
        //Read all the communities that got approved 
        public List<Community> ReadAllApprovedCommunitis()
        {
            DBservices db = new DBservices();

            return db.ReadAllApprovedCommunitis();
        } 
        //Read all the communities that wating to get approved 
        public List<Community> ReadAllPendingCommunities()
        {
            DBservices db = new DBservices();

            return db.ReadAllPendingCommunities();
        }

        //insert new Community and 
        public int Insert(User user)
        {
            //communities.Add(new Community(1, "dror","Ramat yishay", "ddd", "best", "pic"));  
            //communitiesList.Add(this);  
            DBservices db = new DBservices();

            return db.insertNewCommunity(this, user);
        }


        //Update Community Approval Status
        public int UpdateCommunityApprovalStatus(int communityId, string approvalStatus)
        {
            DBservices db = new DBservices();
            int NumEffected = db.UpdateCommunityApprovalStatus(communityId, approvalStatus);

            if (approvalStatus == "Approved")
            {
                User user = new User();
                user = db.ReadManagerForSpecificCommunity(communityId);
                Managers.Add(user);
            }

            return NumEffected;
        }

        //Get All the Users for spesific community
        //public List<User> ReadAllUsers(Community community)
        //{
        //    return;
        //}

        //Update Community details 

        //Delete community
        //public int Delete() { }



    }
}
