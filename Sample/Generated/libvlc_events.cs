// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace libvlcsharp.generated
{
    /// <summary>Event types</summary>
    public enum EventType
    {
        MediaMetaChanged = 0,
        MediaSubItemAdded = 1,
        MediaDurationChanged = 2,
        MediaParsedChanged = 3,
        MediaFreed = 4,
        MediaStateChanged = 5,
        MediaSubItemTreeAdded = 6,
        MediaPlayerMediaChanged = 256,
        MediaPlayerNothingSpecial = 257,
        MediaPlayerOpening = 258,
        MediaPlayerBuffering = 259,
        MediaPlayerPlaying = 260,
        MediaPlayerPaused = 261,
        MediaPlayerStopped = 262,
        MediaPlayerForward = 263,
        MediaPlayerBackward = 264,
        MediaPlayerEndReached = 265,
        MediaPlayerEncounteredError = 266,
        MediaPlayerTimeChanged = 267,
        MediaPlayerPositionChanged = 268,
        MediaPlayerSeekableChanged = 269,
        MediaPlayerPausableChanged = 270,
        MediaPlayerTitleChanged = 271,
        MediaPlayerSnapshotTaken = 272,
        MediaPlayerLengthChanged = 273,
        MediaPlayerVout = 274,
        MediaPlayerScrambledChanged = 275,
        MediaPlayerESAdded = 276,
        MediaPlayerESDeleted = 277,
        MediaPlayerESSelected = 278,
        MediaPlayerCorked = 279,
        MediaPlayerUncorked = 280,
        MediaPlayerMuted = 281,
        MediaPlayerUnmuted = 282,
        MediaPlayerAudioVolume = 283,
        MediaPlayerAudioDevice = 284,
        MediaPlayerChapterChanged = 285,
        MediaListItemAdded = 512,
        MediaListWillAddItem = 513,
        MediaListItemDeleted = 514,
        MediaListWillDeleteItem = 515,
        MediaListEndReached = 516,
        MediaListViewItemAdded = 768,
        MediaListViewWillAddItem = 769,
        MediaListViewItemDeleted = 770,
        MediaListViewWillDeleteItem = 771,
        MediaListPlayerPlayed = 1024,
        MediaListPlayerNextItemSet = 1025,
        MediaListPlayerStopped = 1026,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_start()</para>
        /// </remarks>
        MediaDiscovererStarted = 1280,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        MediaDiscovererEnded = 1281,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        RendererDiscovererItemAdded = 1282,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        RendererDiscovererItemDeleted = 1283,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaAdded = 1536,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaRemoved = 1537,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaChanged = 1538,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStarted = 1539,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStopped = 1540,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusInit = 1541,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusOpening = 1542,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusPlaying = 1543,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusPause = 1544,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusEnd = 1545,
        /// <remarks>
        /// <para>Useless event, it will be triggered only when calling</para>
        /// <para>libvlc_media_discoverer_stop()</para>
        /// </remarks>
        VlmMediaInstanceStatusError = 1546
    }

    /// <summary>Renderer item</summary>
    /// <remarks>
    /// <para>This struct is passed by a</para>
    /// <para>or deleted.</para>
    /// <para>An item is valid until the</para>
    /// <para>is called with the same pointer.</para>
    /// <para>libvlc_renderer_discoverer_event_manager()</para>
    /// </remarks>
    /// <summary>A LibVLC event</summary>
    public unsafe partial struct Event
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int type;

            [FieldOffset(8)]
            internal global::System.IntPtr p_obj;

            [FieldOffset(16)]
            internal global::libvlcsharp.generated.Event._.__Internal u;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0libvlc_event_t@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 16)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.MetaType.__Internal media_meta_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewChild.__Internal media_subitem_added;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewDuration.__Internal media_duration_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewStatus.__Internal media_parsed_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.Md.__Internal media_freed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewState.__Internal media_state_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.Item.__Internal media_subitemtree_added;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewCache.__Internal media_player_buffering;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewChapter.__Internal media_player_chapter_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewPosition.__Internal media_player_position_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewTime.__Internal media_player_time_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewTitle.__Internal media_player_title_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewSeekable.__Internal media_player_seekable_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewPausable.__Internal media_player_pausable_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewScrambled.__Internal media_player_scrambled_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewCount.__Internal media_player_vout;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.__.__Internal media_list_item_added;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.___.__Internal media_list_will_add_item;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.____.__Internal media_list_item_deleted;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._._____.__Internal media_list_will_delete_item;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.item__.__Internal media_list_player_next_item_set;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.PszFilename.__Internal media_player_snapshot_taken;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewLength.__Internal media_player_length_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.______.__Internal vlm_media_event;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.NewMedia.__Internal media_player_media_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._._______.__Internal media_player_es_changed;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.Volume.__Internal media_player_audio_volume;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.Device.__Internal media_player_audio_device;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.item___.__Internal renderer_discoverer_item_added;

                [FieldOffset(0)]
                internal global::libvlcsharp.generated.Event._.item.__Internal renderer_discoverer_item_deleted;
            }

            public unsafe partial class MetaType
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::libvlcsharp.generated.MetadataType meta_type;
                }
            }

            public unsafe partial class NewChild
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr new_child;
                }
            }

            public unsafe partial class NewDuration
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal long new_duration;
                }
            }

            public unsafe partial class NewStatus
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_status;
                }
            }

            public unsafe partial class Md
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr md;
                }
            }

            public unsafe partial class NewState
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_state;
                }
            }

            public unsafe partial class Item
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;
                }
            }

            public unsafe partial class NewCache
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal float new_cache;
                }
            }

            public unsafe partial class NewChapter
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_chapter;
                }
            }

            public unsafe partial class NewPosition
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal float new_position;
                }
            }

            public unsafe partial class NewTime
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal long new_time;
                }
            }

            public unsafe partial class NewTitle
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_title;
                }
            }

            public unsafe partial class NewSeekable
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_seekable;
                }
            }

            public unsafe partial class NewPausable
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_pausable;
                }
            }

            public unsafe partial class NewScrambled
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_scrambled;
                }
            }

            public unsafe partial class NewCount
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal int new_count;
                }
            }

            public unsafe partial class __
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;

                    [FieldOffset(8)]
                    internal int index;
                }
            }

            public unsafe partial class ___
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;

                    [FieldOffset(8)]
                    internal int index;
                }
            }

            public unsafe partial class ____
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;

                    [FieldOffset(8)]
                    internal int index;
                }
            }

            public unsafe partial class _____
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;

                    [FieldOffset(8)]
                    internal int index;
                }
            }

            public unsafe partial class item__
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;
                }
            }

            public unsafe partial class PszFilename
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr psz_filename;
                }
            }

            public unsafe partial class NewLength
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal long new_length;
                }
            }

            public unsafe partial class ______
            {
                [StructLayout(LayoutKind.Explicit, Size = 16)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr psz_media_name;

                    [FieldOffset(8)]
                    internal global::System.IntPtr psz_instance_name;
                }
            }

            public unsafe partial class NewMedia
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr new_media;
                }
            }

            public unsafe partial class _______
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::libvlcsharp.generated.TrackType i_type;

                    [FieldOffset(4)]
                    internal int i_id;
                }
            }

            public unsafe partial class Volume
            {
                [StructLayout(LayoutKind.Explicit, Size = 4)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal float volume;
                }
            }

            public unsafe partial class Device
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr device;
                }
            }

            public unsafe partial class item___
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;
                }
            }

            public unsafe partial class item
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr item;
                }
            }
        }

        private Event.__Internal __instance;
        internal Event.__Internal __Instance { get { return __instance; } }

        internal static global::libvlcsharp.generated.Event __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::libvlcsharp.generated.Event(native.ToPointer(), skipVTables);
        }

        internal static global::libvlcsharp.generated.Event __CreateInstance(global::libvlcsharp.generated.Event.__Internal native, bool skipVTables = false)
        {
            return new global::libvlcsharp.generated.Event(native, skipVTables);
        }

        private Event(global::libvlcsharp.generated.Event.__Internal native, bool skipVTables = false)
            : this()
        {
            __instance = native;
        }

        private Event(void* native, bool skipVTables = false) : this()
        {
            __instance = *(global::libvlcsharp.generated.Event.__Internal*) native;
        }

        public Event(global::libvlcsharp.generated.Event _0)
            : this()
        {
            var ____arg0 = _0.__Instance;
            var __arg0 = new global::System.IntPtr(&____arg0);
            fixed (__Internal* __instancePtr = &__instance)
            {
                __Internal.cctor(new global::System.IntPtr(__instancePtr), __arg0);
            }
        }

        public int Type
        {
            get
            {
                return __instance.type;
            }

            set
            {
                __instance.type = value;
            }
        }

        public global::System.IntPtr PObj
        {
            get
            {
                return __instance.p_obj;
            }

            set
            {
                __instance.p_obj = (global::System.IntPtr) value;
            }
        }
    }
}
