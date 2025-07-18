﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Media_Player
{
	public static class TaskbarProgress
	{
		public enum TaskbarStates
		{
			NoProgress = 0,
			Indeterminate = 0x1,
			Normal = 0x2,
			Error = 0x4,
			Paused = 0x8
		}

		[ComImport()]
		[Guid("ea1afb91-9e28-4b86-90e9-9e9f8a5eefaf")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		private interface ITaskbarList3
		{
			// ITaskbarList
			[PreserveSig]
			void HrInit();
			[PreserveSig]
			void AddTab(IntPtr hwnd);
			[PreserveSig]
			void DeleteTab(IntPtr hwnd);
			[PreserveSig]
			void ActivateTab(IntPtr hwnd);
			[PreserveSig]
			void SetActiveAlt(IntPtr hwnd);

			// ITaskbarList2
			[PreserveSig]
			void MarkFullscreenWindow(IntPtr hwnd, [MarshalAs(UnmanagedType.Bool)] bool fFullscreen);

			// ITaskbarList3
			[PreserveSig]
			void SetProgressValue(IntPtr hwnd, UInt64 ullCompleted, UInt64 ullTotal);
			[PreserveSig]
			void SetProgressState(IntPtr hwnd, TaskbarStates state);
		}

		[ComImport()]
		[Guid("56fdf344-fd6d-11d0-958a-006097c9a090")]
		[ClassInterface(ClassInterfaceType.None)]
		private class TaskbarInstance
		{
		}

		private static ITaskbarList3 taskbarInstance = (ITaskbarList3)new TaskbarInstance();
		private static bool taskbarSupported = Environment.OSVersion.Version >= new Version(6, 1);

		public static void SetState(IntPtr windowHandle, TaskbarStates taskbarState)
		{
			if (taskbarSupported) taskbarInstance.SetProgressState(windowHandle, taskbarState);
		}

		public static void SetValue(IntPtr windowHandle, double progressValue, double progressMax)
		{
			if (taskbarSupported) taskbarInstance.SetProgressValue(windowHandle, (ulong)progressValue, (ulong)progressMax);
		}
	}
	public class NativeMethods
	{
		public const int MAX_PATH = 260;

		[Flags]
		public enum SHGSI : uint
		{
			SHGSI_ICONLOCATION = 0,
			SHGSI_ICON = 0x000000100,
			SHGSI_SYSICONINDEX = 0x000004000,
			SHGSI_LINKOVERLAY = 0x000008000,
			SHGSI_SELECTED = 0x000010000,
			SHGSI_LARGEICON = 0x000000000,
			SHGSI_SMALLICON = 0x000000001,
			SHGSI_SHELLICONSIZE = 0x000000004
		}
		public enum SHSTOCKICONID : uint
		{
			SIID_DOCNOASSOC = 0,          //Blank document icon (Document of a type with no associated application).
			SIID_DOCASSOC = 1,            //Application-associated document icon (Document of a type with an associated application).
			SIID_APPLICATION = 2,         //Generic application with no custom icon.
			SIID_FOLDER = 3,              //Folder (generic, unspecified state).
			SIID_FOLDEROPEN = 4,          //Folder (open).
			SIID_DRIVE525 = 5,            //5.25-inch disk drive.
			SIID_DRIVE35 = 6,             //3.5-inch disk drive.
			SIID_DRIVEREMOVE = 7,         //Removable drive.
			SIID_DRIVEFIXED = 8,          //Fixed drive (hard disk).
			SIID_DRIVENET = 9,            //Network drive (connected).
			SIID_DRIVENETDISABLED = 10,   //Network drive (disconnected).
			SIID_DRIVECD = 11,            //CD drive.
			SIID_DRIVERAM = 12,           //RAM disk drive.
			SIID_WORLD = 13,              //The entire network.
			SIID_SERVER = 15,             //A computer on the network.
			SIID_PRINTER = 16,            //A local printer or print destination.
			SIID_MYNETWORK = 17,          //The Network virtual folder (FOLDERID_NetworkFolder/CSIDL_NETWORK).
			SIID_FIND = 22,               //The Search feature.
			SIID_HELP = 23,               //The Help and Support feature.
			SIID_SHARE = 28,              //Overlay for a shared item.
			SIID_LINK = 29,               //Overlay for a shortcut.
			SIID_SLOWFILE = 30,           //Overlay for items that are expected to be slow to access.
			SIID_RECYCLER = 31,           //The Recycle Bin (empty).
			SIID_RECYCLERFULL = 32,       //The Recycle Bin (not empty).
			SIID_MEDIACDAUDIO = 40,       //Audio CD media.
			SIID_LOCK = 47,               //Security lock.
			SIID_AUTOLIST = 49,           //A virtual folder that contains the results of a search.
			SIID_PRINTERNET = 50,         //A network printer.
			SIID_SERVERSHARE = 51,        //A server shared on a network.
			SIID_PRINTERFAX = 52,         //A local fax printer.
			SIID_PRINTERFAXNET = 53,      //A network fax printer.
			SIID_PRINTERFILE = 54,        //A file that receives the output of a Print to file operation.
			SIID_STACK = 55,              //A category that results from a Stack by command to organize the contents of a folder.
			SIID_MEDIASVCD = 56,          //Super Video CD (SVCD) media.
			SIID_STUFFEDFOLDER = 57,      //A folder that contains only subfolders as child items.
			SIID_DRIVEUNKNOWN = 58,       //Unknown drive type.
			SIID_DRIVEDVD = 59,           //DVD drive.
			SIID_MEDIADVD = 60,           //DVD media.
			SIID_MEDIADVDRAM = 61,        //DVD-RAM media.
			SIID_MEDIADVDRW = 62,         //DVD-RW media.
			SIID_MEDIADVDR = 63,          //DVD-R media.
			SIID_MEDIADVDROM = 64,        //DVD-ROM media.
			SIID_MEDIACDAUDIOPLUS = 65,   //CD+ (enhanced audio CD) media.
			SIID_MEDIACDRW = 66,          //CD-RW media.
			SIID_MEDIACDR = 67,           //CD-R media.
			SIID_MEDIACDBURN = 68,        //A writeable CD in the process of being burned.
			SIID_MEDIABLANKCD = 69,       //Blank writable CD media.
			SIID_MEDIACDROM = 70,         //CD-ROM media.
			SIID_AUDIOFILES = 71,         //An audio file.
			SIID_IMAGEFILES = 72,         //An image file.
			SIID_VIDEOFILES = 73,         //A video file.
			SIID_MIXEDFILES = 74,         //A mixed file.
			SIID_FOLDERBACK = 75,         //Folder back.
			SIID_FOLDERFRONT = 76,        //Folder front.
			SIID_SHIELD = 77,             //Security shield. Use for UAC prompts only.
			SIID_WARNING = 78,            //Warning.
			SIID_INFO = 79,               //Informational.
			SIID_ERROR = 80,              //Error.
			SIID_KEY = 81,                //Key.
			SIID_SOFTWARE = 82,           //Software.
			SIID_RENAME = 83,             //A UI item, such as a button, that issues a rename command.
			SIID_DELETE = 84,             //A UI item, such as a button, that issues a delete command.
			SIID_MEDIAAUDIODVD = 85,      //Audio DVD media.
			SIID_MEDIAMOVIEDVD = 86,      //Movie DVD media.
			SIID_MEDIAENHANCEDCD = 87,    //Enhanced CD media.
			SIID_MEDIAENHANCEDDVD = 88,   //Enhanced DVD media.
			SIID_MEDIAHDDVD = 89,         //High definition DVD media in the HD DVD format.
			SIID_MEDIABLURAY = 90,        //High definition DVD media in the Blu-ray Disc™ format.
			SIID_MEDIAVCD = 91,           //Video CD (VCD) media.
			SIID_MEDIADVDPLUSR = 92,      //DVD+R media.
			SIID_MEDIADVDPLUSRW = 93,     //DVD+RW media.
			SIID_DESKTOPPC = 94,          //A desktop computer.
			SIID_MOBILEPC = 95,           //A mobile computer (laptop).
			SIID_USERS = 96,              //The User Accounts Control Panel item.
			SIID_MEDIASMARTMEDIA = 97,    //Smart media.
			SIID_MEDIACOMPACTFLASH = 98,  //CompactFlash media.
			SIID_DEVICECELLPHONE = 99,    //A cell phone.
			SIID_DEVICECAMERA = 100,      //A digital camera.
			SIID_DEVICEVIDEOCAMERA = 101, //A digital video camera.
			SIID_DEVICEAUDIOPLAYER = 102, //An audio player.
			SIID_NETWORKCONNECT = 103,    //Connect to network.
			SIID_INTERNET = 104,          //The Network and Internet Control Panel item.
			SIID_ZIPFILE = 105,           //A compressed file with a .zip file name extension.
			SIID_SETTINGS = 106,          //The Additional Options Control Panel item.
			SIID_DRIVEHDDVD = 132,        //Windows Vista with Service Pack 1 (SP1) and later. High definition DVD drive (any type - HD DVD-ROM, HD DVD-R, HD-DVD-RAM) that uses the HD DVD format.
			SIID_DRIVEBD = 133,           //Windows Vista with SP1 and later. High definition DVD drive (any type - BD-ROM, BD-R, BD-RE) that uses the Blu-ray Disc format.
			SIID_MEDIAHDDVDROM = 134,     //Windows Vista with SP1 and later. High definition DVD-ROM media in the HD DVD-ROM format.
			SIID_MEDIAHDDVDR = 135,       //Windows Vista with SP1 and later. High definition DVD-R media in the HD DVD-R format.
			SIID_MEDIAHDDVDRAM = 136,     //Windows Vista with SP1 and later. High definition DVD-RAM media in the HD DVD-RAM format.
			SIID_MEDIABDROM = 137,        //Windows Vista with SP1 and later. High definition DVD-ROM media in the Blu-ray Disc BD-ROM format.
			SIID_MEDIABDR = 138,          //Windows Vista with SP1 and later. High definition write-once media in the Blu-ray Disc BD-R format.
			SIID_MEDIABDRE = 139,         //Windows Vista with SP1 and later. High definition read/write media in the Blu-ray Disc BD-RE format.
			SIID_CLUSTEREDDRIVE = 140,    //Windows Vista with SP1 and later. A cluster disk array.
			SIID_MAX_ICONS = 174,         //The highest valid value in the enumeration. Values over 160 are Windows 7-only icons.
		}
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		public struct SHSTOCKICONINFO
		{
			public UInt32 cbSize;
			public IntPtr hIcon;
			public Int32 iSysIconIndex;
			public Int32 iIcon;
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH)]
			public string szPath;
		}
		[DllImport("Shell32.dll", SetLastError = false)]
		public static extern Int32 SHGetStockIconInfo(SHSTOCKICONID siid, SHGSI uFlags, ref SHSTOCKICONINFO psii);
	}
}
