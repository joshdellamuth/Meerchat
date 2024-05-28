using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meerchat.Api.Core.Entities
{
    public class Chat : BaseEntity
    {
        public int ChatId { get; set; }
        public int ChatGroupId { get; set; }
        public int SenderUserId { get; set; }
        public string? ChatContent { get; set; }
        public DateTime SentDateTime { get; set; }
    }
}
