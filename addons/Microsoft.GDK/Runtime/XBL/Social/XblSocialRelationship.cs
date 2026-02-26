using System;
using GDK.XGamingRuntime.Interop;

namespace GDK.XGamingRuntime
{
    public class XblSocialRelationship
    {
        internal XblSocialRelationship(Interop.XblSocialRelationship interopHandle)
        {
            this.XboxUserId = interopHandle.xboxUserId;
            this.IsFavourite = interopHandle.isFavorite;
            this.IsFriend = false;
            this.IsFollowingCaller = interopHandle.isFollowingCaller;
            this.SocialNetworks = interopHandle.GetSocialNetworks();
        }

        internal XblSocialRelationship(Interop.XblSocialRelationship2 interopHandle)
        {
            this.XboxUserId = interopHandle.xboxUserId;
            this.IsFavourite = interopHandle.isFavorite;
            this.IsFriend = interopHandle.isFriend;
            this.IsFollowingCaller = interopHandle.isFollowingCaller;
            this.SocialNetworks = interopHandle.GetSocialNetworks();
        }

        public UInt64 XboxUserId { get; }

        public bool IsFavourite { get; }

        public bool IsFriend 
        {
            get
            {
                // Version check only in debug/development builds
#if DEBUG || DEVELOPMENT_BUILD
                if (!s_isFriendWarningShown && SDK.GetGdkEdition() < 241000)
                {
                    s_isFriendWarningShown = true;
                }
#endif

                return m_isFriend;
            }
            private set
            {
                m_isFriend = value;
            }
        }

        public bool IsFollowingCaller { get; }

        public string[] SocialNetworks { get; }

#if DEBUG || DEVELOPMENT_BUILD
        // Static flag only exists in none release builds
        private static bool s_isFriendWarningShown = false;
#endif

        private bool m_isFriend;
    }
}   
