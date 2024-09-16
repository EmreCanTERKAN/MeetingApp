namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();

        //veri tabanı olmadığı için static bir list tanımladık ..

        // bir instance oluştuğunda otomatik olarak constructor ile oluşturulacak.
        static Repository()
        {
            _users.Add(new UserInfo() { Id=1, Name = "Ahmet BİLGİN" , Email = "lider@hotmail.com", Phone = "031313131", WillAttend = true });
            _users.Add(new UserInfo() {Id=2, Name = "Emre Can TERKAN", Email = "ezik@noob.com", Phone = "23424", WillAttend = false });
            _users.Add(new UserInfo() {Id=3, Name = "Erdi TURGUT", Email = "sinirli@123.com", Phone = "23424", WillAttend = true });
        }

        public static List<UserInfo> Users { get { return _users; } } 

        public static void CreateUser(UserInfo user)
        {
            user.Id = Users.Count + 1;
            _users.Add(user);
        }
        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(x => x.Id == id);
        }
    }
}
