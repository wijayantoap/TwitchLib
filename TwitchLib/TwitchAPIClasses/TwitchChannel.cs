﻿using Newtonsoft.Json.Linq;

namespace TwitchLib
{
    public class TwitchChannel
    {
        private bool _mature;
        private bool _partner;

        private string _status,
            _broadcasterLanguage,
            _displayName,
            _game,
            _language,
            _name,
            _createdAt,
            _updatedAt,
            _delay,
            _logo,
            _background,
            _profileBanner;

        private int _id, _views, _followers;

        public string Status => _status;
        public string BroadcasterLanguage => _broadcasterLanguage;
        public string DisplayName => _displayName;
        public string Game => _game;
        public string Language => _language;
        public string Name => _name;
        public string CreatedAt => _createdAt;
        public string UpdatedAt => _updatedAt;
        public string Delay => _delay;
        public string Logo => _logo;
        public string Background => _background;
        public string ProfileBanner => _profileBanner;
        public bool Mature => _mature;
        public bool Partner => _partner;
        public int Id => _id;
        public int Views => _views;
        public int Followers => _followers;

        public TwitchChannel(JObject json)
        {
            if (json.SelectToken("mature").ToString() == "True") _mature = true;
            if (json.SelectToken("partner").ToString() == "True") _partner = true;

            _status = json.SelectToken("status").ToString();
            _broadcasterLanguage = json.SelectToken("broadcaster_language").ToString();
            _displayName = json.SelectToken("display_name").ToString();
            _game = json.SelectToken("game").ToString();
            _language = json.SelectToken("language").ToString();
            _id = int.Parse(json.SelectToken("_id").ToString());
            _name = json.SelectToken("name").ToString();
            _createdAt = json.SelectToken("created_at").ToString();
            _updatedAt = json.SelectToken("updated_at").ToString();
            _delay = json.SelectToken("delay").ToString();
            _logo = json.SelectToken("logo").ToString();
            _background = json.SelectToken("background").ToString();
            _profileBanner = json.SelectToken("profile_banner").ToString();
            _views = int.Parse(json.SelectToken("views").ToString());
            _followers = int.Parse(json.SelectToken("followers").ToString());
        }
    }
}