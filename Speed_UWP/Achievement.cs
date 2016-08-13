using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_UWP
{
    class Achievement
    {
        /// <summary>
        /// A field variable that stores the name of the achievement name
        /// </summary>
        string _achievementName;

        /// <summary>
        /// A field variable that stores the requirement for the achievement
        /// </summary>
        string _achievementRequirement;

        /// <summary>
        /// A field variable to store the status of the achivement; true or false
        /// </summary>
        bool _achievementStatus;

        // Potentiallt include the addition of a image to visually signify the
        // achivement status?

        /// <summary>
        /// Achievement constructor; will create achievements that have a name and requirement
        /// </summary>
        /// <param name="achievementName">Achivement name</param>
        /// <param name="requirement">Requirement for achivement</param>
        public Achievement(string achievementName, string requirement)
        {
            _achievementName = achievementName;
            _achievementRequirement = requirement;
            _achievementStatus = false;
        }

        // Make sure to also save the _acivement on a file with a list of other acheived achievements (xml, json, etc.?)
        ///
        public void AchievementMet()
        {
            _achievementStatus = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Achivement details and status</returns>
        public override string ToString()
        {
            string status = "";

            if (_achievementStatus == false)
            {
                status = "Not yet achieved";
            }
            else if (_achievementStatus == true)
            {
                status = "Achieved!";
            }
            return $"- {_achievementName}\nRequirements: {_achievementRequirement} | Status: {status}";
        }
    }
}
