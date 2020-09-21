
using Newtonsoft.Json;

namespace ImsGlobal.Caliper.Events
{
    public enum CaliperAction
    {
        /// <summary>
        /// Forsake, leave behind.
        /// </summary>
        Abandoned,

        /// <summary>
        /// Make active or more active. <b>Inverse of Deactivated.</b>
        /// </summary>
        Activated,

        /// <summary>
        /// Make an addition (to); join or combine or unite with others; increase the quality, quantity, size or scope of. 
        /// <b>Inverse of Removed</b>.
        /// </summary>
        Added,

        /// <summary>
        /// Cause to be attached.
        /// </summary>
        Attached,

        /// <summary>
        /// A marker that specifies a location of interest in a DigitalResource that is recorded for later retrieval.
        /// </summary>
        Bookmarked,

        /// <summary>
        /// Cause to change; make different; cause a transformation of the number of pixels per square inch on a 
        /// computer-generated display.
        /// </summary>
        ChangedResolution,

        /// <summary>
        /// Cause to change; make different; cause a transformation of the physical magnitude of something.
        /// </summary>
        ChangedSize,

        /// <summary>
        /// Cause to change; make different; cause a transformation of the rate at which something happens.
        /// </summary>
        ChangedSpeed,

        /// <summary>
        /// Cause to change; make different; cause a transformation of the magnitude of sound (usually in a specified direction).
        /// </summary>
        ChangedVolume,

        /// <summary>
        /// Assign to a class or kind.
        /// </summary>
        Classified,

        /// <summary>
        /// Close or shut a video popout. <b>Inverse of OpenedPopout</b>.
        /// </summary>
        ClosedPopout,

        /// <summary>
        /// Make or write a comment on.
        /// </summary>
        Commented,

        /// <summary>
        /// Come or bring to a finish or an end.
        /// </summary>
        Completed,

        /// <summary>
        /// Make or cause to be or to become. Inverse of Deleted.
        /// </summary>
        Created,

        /// <summary>
        /// Make inactive. Inverse of Activated.
        /// </summary>
        Deactivated,

        /// <summary>
        /// Wipe out digitally. Inverse of Created.
        /// </summary>
        Deleted,

        /// <summary>
        /// Give a description of.
        /// </summary>
        Described,

        /// <summary>
        /// Render unable to perform the visual display of a plain text transcription of audio output. 
        /// Inverse of EnabledClosedCaptioning.
        /// </summary>
        DisabledClosedCaptioning,

        /// <summary>
        /// Have or feel a dislike or distaste for. Inverse of Liked.
        /// </summary>
        Disliked,

        /// <summary>
        /// Render capable or able the visual display of a plain text transcription of audio output. 
        /// Inverse of DisabledClosedCaptioning.
        /// </summary>
        EnabledClosedCaptioning,

        /// <summary>
        /// Bring to an end or halt. Inverse of Started.
        /// </summary>
        Ended,

        /// <summary>
        /// To come or go into a view mode that utilizes all the available display surface of a screen. 
        /// Inverse of ExitedFullScreen.
        /// </summary>
        EnteredFullScreen,

        /// <summary>
        /// Move out of or depart from a view mode that utilizes all the available display surface of a screen. 
        /// Inverse of EnteredFullScreen.
        /// </summary>
        ExitedFullScreen,

        /// <summary>
        /// Send or ship onward.
        /// </summary>
        ForwardedTo,

        /// <summary>
        /// Assign a grade or rank to, according to one’s evaluation.
        /// </summary>
        Graded,

        /// <summary>
        /// Prevent from being seen or discovered. Inverse of Showed.
        /// </summary>
        Hid,

        /// <summary>
        /// Move into the foreground to make more visible or prominent.
        /// </summary>
        Highlighted,

        /// <summary>
        /// Recognize as being; establish the identity of someone or something.
        /// </summary>
        Identified,

        /// <summary>
        /// Pass abruptly from one state or topic to another.
        /// </summary>
        JumpedTo,

        /// <summary>
        /// Be fond of. Inverse of Disliked.
        /// </summary>
        Liked,

        /// <summary>
        /// Connect, fasten, or put together two or more pieces.
        /// </summary>
        Linked,

        /// <summary>
        /// Enter a computer or software application. Inverse of LoggedOut.
        /// </summary>
        LoggedIn,

        /// <summary>
        /// Exit a computer or software application. Inverse of LoggedIn.
        /// </summary>
        LoggedOut,

        /// <summary>
        /// Mark: designate as if by a mark, read: interpret something that is written or printed. Inverse of MarkedAsUnread.
        /// </summary>
        MarkedAsRead,

        /// <summary>
        /// Inverse of MarkedAsRead.
        /// </summary>
        MarkedAsUnread,

        /// <summary>
        /// Cause to change; make different; cause a transformation.
        /// </summary>
        Modified,

        /// <summary>
        /// Deaden (a sound or noise). Inverse of Unmuted.
        /// </summary>
        Muted,

        /// <summary>
        /// Direct the course; determine the direction of travelling.
        /// </summary>
        NavigatedTo,

        /// <summary>
        /// Start to operate or function or cause to start operating or functioning a video popout. Inverse of ClosedPopout.
        /// </summary>
        OpenedPopout,

        /// <summary>
        /// Cease an action temporarily. Inverse of Resumed.
        /// </summary>
        Paused,

        /// <summary>
        /// To cause to be directed or transmitted to another place.
        /// </summary>
        Posted,

        /// <summary>
        /// Pose a question.
        /// </summary>
        Questioned,

        /// <summary>
        /// Assign a rank or rating to.
        /// </summary>
        Ranked,

        /// <summary>
        /// Express a good opinion of.
        /// </summary>
        Recommended,

        /// <summary>
        /// Remove from sight. Inverse of Added.
        /// </summary>
        Removed,

        /// <summary>
        /// Set anew.
        /// </summary>
        Reset,

        /// <summary>
        /// Take up or begin anew, as in to start something, make progress but then stop and return to the beginning in 
        /// order to start again.
        /// </summary>
        Restarted,

        /// <summary>
        /// Take up or begin anew, as in to start something, pause and then begin again at the location where the pause 
        /// in action occurred. Inverse of Paused.
        /// </summary>
        Resumed,

        /// <summary>
        /// Obtain or retrieve from a storage device; as of information on a computer.
        /// </summary>
        Retrieved,

        /// <summary>
        /// Appraise critically.
        /// </summary>
        Reviewed,

        /// <summary>
        /// Wind up again.
        /// </summary>
        Rewound,

        /// <summary>
        /// Try to locate or discover, or try to establish the existence of.
        /// </summary>
        Searched,

        /// <summary>
        /// Communicate.
        /// </summary>
        Shared,

        /// <summary>
        /// Make visible or noticeable. Inverse of Hid.
        /// </summary>
        Showed,

        /// <summary>
        /// Bypass.
        /// </summary>
        Skipped,

        /// <summary>
        /// Set in motion, cause to start. Inverse of Ended.
        /// </summary>
        Started,

        /// <summary>
        /// Hand over formally.
        /// </summary>
        Submitted,

        /// <summary>
        /// Receive or obtain regularly. Inverse of Unsubscribed.
        /// </summary>
        Subscribed,

        /// <summary>
        /// Attach a tag or label to.
        /// </summary>
        Tagged,

        /// <summary>
        /// Cancellation of a user session after a predetermined time interval has occurred without activity.
        /// </summary>
        TimedOut,

        /// <summary>
        /// Inverse of Muted.
        /// </summary>
        Unmuted,

        /// <summary>
        /// Inverse of Subscribed.
        /// </summary>
        Unsubscribed,

        /// <summary>
        /// Put into service; make work or employ for a particular purpose or for its inherent or natural purpose.
        /// </summary>
        Used,

        /// <summary>
        /// Look at carefully; study mentally.
        /// </summary>
        Viewed,
    }
}

