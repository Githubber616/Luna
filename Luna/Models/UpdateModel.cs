﻿using Luna.Utils;
using System;
using System.Xml.Serialization;

namespace Luna.Models
{
    public enum UpdateStatus
    {
        Error = -1,
        None = 0,
        NoUpdate = 1,
        Checking = 2,
        NewUpdate = 3,
        Downloading = 4,
        Ready = 5,
    }

    [XmlRoot("Update")]
    public class UpdateModel : NotifyPropertyChanged
    {
        private UpdateStatus _status = UpdateStatus.None;

        [XmlIgnore]
        public UpdateStatus Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        private double _progress;

        [XmlIgnore]
        public double Progress
        {
            get
            {
                return _progress;
            }
            set
            {
                _progress = value;
                RaisePropertyChanged();
            }
        }

        private string _version;

        [XmlIgnore]
        public string Version
        {
            get
            {
                return _version;
            }
            set
            {
                _version = value;
                RaisePropertyChanged();
            }
        }

        private string _changelog;

        [XmlIgnore]
        public string Changelog
        {
            get
            {
                return _changelog;
            }
            set
            {
                _changelog = value;
                RaisePropertyChanged();
            }
        }

        private string _downloadUrl;

        [XmlIgnore]
        public string DownloadUrl
        {
            get
            {
                return _downloadUrl;
            }
            set
            {
                _downloadUrl = value;
                RaisePropertyChanged();
            }
        }

        private string _downloadPath;

        [XmlIgnore]
        public string DownloadPath
        {
            get
            {
                return _downloadPath;
            }
            set
            {
                _downloadPath = value;
                RaisePropertyChanged();
            }
        }

        private string _downloadName;

        [XmlIgnore]
        public string DownloadName
        {
            get
            {
                return _downloadName;
            }
            set
            {
                _downloadName = value;
                RaisePropertyChanged();
            }
        }

        private DateTime _lastCheck;

        [XmlAttribute("LastCheck")]
        public DateTime LastCheck
        {
            get
            {
                return _lastCheck;
            }
            set
            {
                _lastCheck = value;
                RaisePropertyChanged();
            }
        }

        [XmlIgnore]
        public double LastCheckInMinutes
        {
            get
            {
                return (DateTime.Now - LastCheck).TotalMinutes;
            }
        }
    }
}
