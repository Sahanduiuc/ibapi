using System;

namespace TwsRtdServer
{
    // class represents RTD server topic (id, value, string name) (e.g. [25, 177.55, "BID"])
    public class TwsRtdServerTopic
    {
        // vars
        private int m_topicId = -1;
        private Object m_topicValue;
        private string m_topicStr;

        // constructor
        public TwsRtdServerTopic(string topicStr, int topicId)
        {
            m_topicStr = topicStr;
            m_topicId = topicId;
            m_topicValue = "";
        }

        public int TopicId()
        {
            return m_topicId;
        }

        public Object TopicValue()
        {
            return m_topicValue;
        }

        public string TopicStr()
        {
            return m_topicStr;
        }

        public void TopicValue(Object topicValue)
        {
            m_topicValue = topicValue;
        }
        
        public static string ParseTopicStrings(Array strings)
        {
            string topicStr = null;
            if (strings != null)
            {
                foreach (string s in strings)
                {
                    if (topicStr == null && s.ToLower().IndexOf(TwsRtdServerData.QT) >= 0)
                    {
                        // parse string like "qt=Bid"
                        topicStr = s.Substring(TwsRtdServerData.QT.Length, s.Length - TwsRtdServerData.QT.Length).ToUpper();

                        if (Array.IndexOf(TwsRtdServerData.AllowedTopics(), topicStr) < 0)
                        {
                            return null; // topic is not allowed
                        }
                    }

                    if (topicStr == null && !s.ToLower().Contains(TwsRtdServerData.LOCALSYMBOL_STR) && s.ToLower().Contains(TwsRtdServerData.CHAR_SPACE.ToString()))
                    {
                        // pasre string like "IBM Bid"
                        topicStr = s.Substring(s.IndexOf(TwsRtdServerData.CHAR_SPACE) + 1, s.Length - 1 - s.IndexOf(TwsRtdServerData.CHAR_SPACE)).ToUpper();

                        if (Array.IndexOf(TwsRtdServerData.AllowedTopics(), topicStr) < 0)
                        {
                            return null; // topic is not allowed
                        }
                    }

                    if (topicStr == null)
                    {
                        // pasre string like "Bid"
                        topicStr = s.ToUpper();

                        if (Array.IndexOf(TwsRtdServerData.AllowedTopics(), topicStr) < 0)
                        {
                            topicStr = null;
                        }
                    }

                }
            }

            if (topicStr == null)
            {
                // topic not found, use default
                topicStr = TwsRtdServerData.LAST;
            }

            return topicStr;

        }

    }
}
