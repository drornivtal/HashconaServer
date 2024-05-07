using Hashchona.DAL;

namespace Hashchona.BL
{
    public class RequestForHelp
    {
        int reqID;
        int categoryId;
        DateTime dueDate;
        DateTime dueTime;  
        DateTime postDate;
        DateTime postTime;
        string description;
        bool gotHelp;
        User userReq;

        public RequestForHelp() { }

        public RequestForHelp(int reqID, int categoryId, DateTime dueDate, DateTime dueTime, DateTime postDate,
                              DateTime postTime, string description, User userReq, bool gotHelp)
        {
            ReqID = reqID;
            CategoryId = categoryId;
            DueDate = dueDate;
            DueTime = dueTime;
            PostDate = postDate;
            PostTime = postTime;
            Description = description;
            UserReq = userReq;
            GotHelp = gotHelp;
        }


        public int ReqID { get => reqID; set => reqID = value; }
        public int CategoryId { get => categoryId; set => categoryId = value; }
        public DateTime DueDate { get => dueDate; set => dueDate = value; }
        public DateTime DueTime { get => dueTime; set => dueTime = value; }
        public DateTime PostDate { get => postDate; set => postDate = value; }
        public DateTime PostTime { get => postTime; set => postTime = value; }
        public string Description { get => description; set => description = value; }
        public User UserReq { get => userReq; set => userReq = value; }
        public bool GotHelp { get => gotHelp; set => gotHelp = value; }




        //insert new request
        public int InsertNewReq(RequestForHelp req)
        {
            DBservices db = new DBservices();
            return db.InsertNewReq(req);
        }

        //Delet request
        public int DeleteReq(RequestForHelp request)
        {
            DBservices db = new DBservices();   
            return db.DeleteReq(request.ReqID);
        }
        //Delet request
        public List<RequestForHelp> readAllActiveCategoryReq(int categoryID)
        {
            DBservices db = new DBservices();   
            return db.readAllActiveCategoryReq(categoryID);
        }


    }
}
