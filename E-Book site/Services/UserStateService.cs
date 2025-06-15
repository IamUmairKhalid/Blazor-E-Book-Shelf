namespace E_Book_site.Services
{
    public class UserStateService
    {
        public event Action? OnChange;

        public string ProfileImageUrl { get; private set; } = "/StaticImages/alt_profile_pic.jpg";
        public string UserName { get; private set; } = "Unknown";
        public int UserId { get; private set; }

        public void SetUser(int id, string name, string imageUrl)
        {
            UserId = id;
            UserName = name;
            ProfileImageUrl = imageUrl;
            NotifyStateChanged();
        }

        public void ClearUser()
        {
            UserId = 0;
            UserName = "Unknown";
            ProfileImageUrl = "/StaticImages/alt_profile_pic.jpg";
        }

        private void NotifyStateChanged() => OnChange?.Invoke();
    }
}
