using System.Collections.Generic;
using static TrainingArena.Practice2;

namespace ImproveReadibility
{
	class DoYouReallyNeedAllTheComments
    {
        /*
         * "Don't comment bad code—rewrite it."
         * 
         * —Brian W. Kernighan and P. J. Plaugher
         * 
         */

        #region Noise Comments

        //List of comments
        private List<string> comments;

		/// <summary>
		/// Constructor.
		/// </summary>
		public DoYouReallyNeedAllTheComments()
		{

		}

		/// <summary>
		/// This gets/sets number of extensions.
		/// </summary>
		public int NumberOfExtensions { get; set; }

        #endregion

        #region Use Method Or Variable Instead Of Comment

        public bool CheckIfCreditCanBeApproved(int amount, int age, int creditDuration)
		{
			//These are conditions where credit can be approved - allowed risk
			if (amount < 100000 || (age < 65 && creditDuration < 15))
			{
				return true;
			}
			//other logic here....
			return false;
		}

		#endregion

		#region CommentedOutCode

		public class Login
        {
            private int loginAttempts = 3;
            private Dictionary<string, string> allowedUsers = new Dictionary<string, string>
            {
                { "admin", "8vYhN#Bp0h^p" },
                { "poweruser", "bH6s0U!8p9Ze" },
                { "superadmin", "y87QqoiG1Vz*" }
            };

            public LoginMessage PerformLogin(string username, string password)
            {
                if (loginAttempts > 0)
                {
                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        loginAttempts--;
                        return new LoginMessage("Username or password is empty.", false);
                    }
                    //else if (!allowedUsers.ContainsKey(username))
                    //{
                    //    loginAttempts--;
                    //    return new LoginMessage("Incorrect username or password.", false);
                    //}
                    else if (allowedUsers[username] != password)
                    {
                        loginAttempts--;
                        return new LoginMessage("Incorrect username or password.", false);
                    }

                    return new LoginMessage("Login succesful", true);
                }
                return new LoginMessage("No more login attempts left.", false);
            }
        }

        #endregion

        #region Dear Journal... Comments

        // Feature 12: Added the initial calculation
        // Fix 38: Remove the unneeded tax deduction
        // Feature 56: Make this more generic
        // Fix 112: Update constants in the method
        public void CalculateEmployeeSalary() { }

        #endregion

        #region Not All Comments Are Bad

        //TODO Opimize for speed
        public void ProcessBankRequest()
        { }

        //Do not delete this method. It's called with reflection.
        private void GetInfoAboutOrder() { }

		#endregion
	}
}
