using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox2021Oct.DataLayer.Context.Enums
{
    /// <summary>
    /// 
    /// </summary>
    public enum FeedbackType
    {
        /// <summary>
        /// 
        /// </summary>
        [Description("Bad candidate")]
        BadCandidate = 1,

        /// <summary>
        /// 
        /// </summary>
        [Description("Good candidate")]
        GoodCandidate = 2,

        /// <summary>
        /// 
        /// </summary>
        [Description("Outstanding candidate")]
        OutstandingCandidate = 3

    }
}
