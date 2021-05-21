using System;

namespace BennyKok.NotionAPI
{
    [Serializable]
    public class Text
    {
        public string type;
        public TextContent text;
        public Annotations annotations;
        public string plain_text;
        public string href;


        [Serializable]
        public class TextContent
        {
            public string content;
            public string link;
        }

        [Serializable]
        public class Annotations
        {
            public bool bold;
            public bool italic;
            public bool strikethrough;
            public bool underline;
            public bool code;
            public string color;
        }
    }

    [Serializable]
    public class Date
    {
        public string start;
        public string end;
    }
}