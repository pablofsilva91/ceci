﻿namespace Ceci.Domain.DTO.User
{
    public class UserRedefinePasswordDTO
    {
        /// <summary>
        /// Current password user
        /// </summary>
        public string CurrentPassword { get; set; }

        /// <summary>
        /// New password user
        /// </summary>
        public string NewPassword { get; set; }
    }
}
