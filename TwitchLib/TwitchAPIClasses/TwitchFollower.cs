﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace TwitchLib.TwitchAPIClasses
{
    public class TwitchFollower
    {
        private string _createdAt;
        private bool _notifications;
        private UserObj _user;

        public string CreatedAt => _createdAt;
        public bool Notifications => _notifications;
        public UserObj User => _user;

        public TwitchFollower(JToken followerData)
        {
            _createdAt = followerData.SelectToken("created_at").ToString();
            if (followerData.SelectToken("notifications").ToString() == "true")
                _notifications = true;
            _user = new UserObj(followerData.SelectToken("user"));
        }

        public class UserObj
        {
            private string _type, _bio, _logo, _displayName, _createdAt, _updatedAt, _name;
            private int _id;

            public string Type => _type;
            public string Bio => _bio;
            public string Logo => _logo;
            public string DisplayName => _displayName;
            public string CreatedAt => _createdAt;
            public string UpdatedAt => _updatedAt;
            public string Name => _name;

            public UserObj(JToken userData)
            {
                _type = userData.SelectToken("type").ToString();
                _bio = userData.SelectToken("bio").ToString();
                _logo = userData.SelectToken("logo").ToString();
                _displayName = userData.SelectToken("display_name").ToString();
                _createdAt = userData.SelectToken("created_at").ToString();
                _updatedAt = userData.SelectToken("updated_at").ToString();
                _id = int.Parse(userData.SelectToken("_id").ToString());
                _name = userData.SelectToken("name").ToString();
            }
        }
    }
}