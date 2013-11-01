using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MailChimp.Lists
{
    [DataContract]
    public class MemberMergeInfo
    {
        [DataMember(Name = "EMAIL")]
        public string Email { get; set; }
        
        [DataMember(Name = "GROUPINGS")]
        public List<MemberGroup> Groups { get; set; }

        [DataContract]
        public class MemberGroup
        {
            [DataMember(Name = "name")]
            public string Name { get; set; }

            [DataMember(Name = "groups")]
            public List<MemberInterestGroups> Groups { get; set; }

            [DataContract]
            public class MemberInterestGroups
            {
                [DataMember(Name = "name")]
                public string Name { get; set; }

                [DataMember(Name = "interested")]
                public bool Interested { get; set; }
            }
        }
    }
}