using System;
using System.Collections.Generic;
using IBApi;

namespace TwsRtdServer
{
    public class TwsRtdServerMktDataTicks
    {
        // latest ticks (we should save ticks in case of non-streaming market data)
        private double m_lastPrice = 0.0;
        private double m_bidPrice = 0.0;
        private double m_askPrice = 0.0;
        private int m_lastSize = 0;
        private int m_bidSize = 0;
        private int m_askSize = 0;
        private double m_high = 0.0;
        private double m_low = 0.0;
        private int m_volume = 0;
        private double m_close = 0.0;
        private double m_open = 0.0;
        private string m_lastExch = "";
        private string m_bidExch = "";
        private string m_askExch = "";
        private string m_lastTime = "";
        private double m_halted = 0.0;

        // add generic ticks values
        private int m_genTickAuctionVolume = 0;
        private int m_genTickAuctionImbalance = 0;
        private double m_genTickAuctionPrice = 0.0;
        private int m_genTickRegulatoryImbalance = 0;
        private double m_genTickPlPrice = 0.0;
        private double m_genTickCreditmanMarkPrice = 0.0;
        private double m_genTickCreditmanSlowMarkPrice = 0.0;
        private int m_genTickCallOptionVolume = 0;
        private int m_genTickPutOptionVolume = 0;
        private int m_genTickCallOptionOpenInterest = 0;
        private int m_genTickPutOptionOpenInterest = 0;
        private double m_genTickOptionHistoricalVol = 0.0;
        private double m_genTickRTHistoricalVol = 0.0;
        private double m_genTickIndexFuturePremium = 0.0;
        private double m_genTickShortable = 0.0;
        private string m_genTickFundamentals = "";
        private double m_genTickTradeCount = 0.0;
        private double m_genTickTradeRate = 0.0;
        private double m_genTickVolumeRate = 0.0;
        private double m_genTickLastRTHTrade = 0.0;
        private string m_genTickIBDividends = "";
        private double m_genTickBondMultiplier = 0.0;
        private int m_genTickAverageVolume = 0;
        private double m_genTickWeek13Hi = 0.0;
        private double m_genTickWeek13Lo = 0.0;
        private double m_genTickWeek26Hi = 0.0;
        private double m_genTickWeek26Lo = 0.0;
        private double m_genTickWeek52Hi = 0.0;
        private double m_genTickWeek52Lo = 0.0;
        private int m_genTickShortTermVolume3Min = 0;
        private int m_genTickShortTermVolume5Min = 0;
        private int m_genTickShortTermVolume10Min = 0;


        // constructor
        public TwsRtdServerMktDataTicks(){
        }

        public void SetValue(string topic, object value)
        {
            // save latest values
            switch (topic)
            {
                case TwsRtdServerData.LAST:
                    m_lastPrice = (double)value;
                    break;
                case TwsRtdServerData.ASK:
                    m_askPrice = (double)value;
                    break;
                case TwsRtdServerData.BID:
                    m_bidPrice = (double)value;
                    break;
                case TwsRtdServerData.LASTSIZE:
                    m_lastSize = (int)value;
                    break;
                case TwsRtdServerData.ASKSIZE:
                    m_askSize = (int)value;
                    break;
                case TwsRtdServerData.BIDSIZE:
                    m_bidSize = (int)value;
                    break;
                case TwsRtdServerData.HIGH:
                    m_high = (double)value;
                    break;
                case TwsRtdServerData.LOW:
                    m_low = (double)value;
                    break;
                case TwsRtdServerData.OPEN:
                    m_open = (double)value;
                    break;
                case TwsRtdServerData.CLOSE:
                    m_close = (double)value;
                    break;
                case TwsRtdServerData.HALTED:
                    m_halted = (double)value;
                    break;
                case TwsRtdServerData.VOLUME:
                    m_volume = (int)value;
                    break;
                case TwsRtdServerData.BIDEXCH:
                    m_bidExch = (string)value;
                    break;
                case TwsRtdServerData.ASKEXCH:
                    m_askExch = (string)value;
                    break;
                case TwsRtdServerData.LASTEXCH:
                    m_lastExch = (string)value;
                    break;
                case TwsRtdServerData.LASTTIME:
                    m_lastTime = (string)value;
                    break;
                // generic ticks
                case TwsRtdServerData.GEN_TICK_AUCTION_VOLUME:
                    m_genTickAuctionVolume = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_AUCTION_IMBALANCE:
                    m_genTickAuctionImbalance = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_AUCTION_PRICE:
                    m_genTickAuctionPrice = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_REGULATORY_IMBALANCE:
                    m_genTickRegulatoryImbalance = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_PL_PRICE:
                    m_genTickPlPrice = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_CREDITMAN_MARK_PRICE:
                    m_genTickCreditmanMarkPrice = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_CREDITMAN_SLOW_MARK_PRICE:
                    m_genTickCreditmanSlowMarkPrice = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_CALL_OPTION_VOLUME:
                    m_genTickCallOptionVolume = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_PUT_OPTION_VOLUME:
                    m_genTickPutOptionVolume = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_CALL_OPTION_OPEN_INTEREST:
                    m_genTickCallOptionOpenInterest = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_PUT_OPTION_OPEN_INTEREST:
                    m_genTickPutOptionOpenInterest = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_OPTION_HISTORICAL_VOL:
                    m_genTickOptionHistoricalVol = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_RT_HISTORICAL_VOL:
                    m_genTickRTHistoricalVol = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_INDEX_FUTURE_PREMIUM:
                    m_genTickIndexFuturePremium = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORTABLE:
                    m_genTickShortable = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_FUNDAMENTALS:
                    m_genTickFundamentals = (string)value;
                    break;
                case TwsRtdServerData.GEN_TICK_TRADE_COUNT:
                    m_genTickTradeCount = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_TRADE_RATE:
                    m_genTickTradeRate = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_VOLUME_RATE:
                    m_genTickVolumeRate = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_LAST_RTH_TRADE:
                    m_genTickLastRTHTrade = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_IB_DIVIDENDS:
                    m_genTickIBDividends = (string)value;
                    break;
                case TwsRtdServerData.GEN_TICK_BOND_MULTIPLIER:
                    m_genTickBondMultiplier = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_AVERAGE_VOLUME:
                    m_genTickAverageVolume = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_13_HI:
                    m_genTickWeek13Hi = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_13_LO:
                    m_genTickWeek13Lo = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_26_HI:
                    m_genTickWeek26Hi = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_26_LO:
                    m_genTickWeek26Lo = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_52_HI:
                    m_genTickWeek52Hi = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_52_LO:
                    m_genTickWeek52Lo = (double)value;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_3_MIN:
                    m_genTickShortTermVolume3Min = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_5_MIN:
                    m_genTickShortTermVolume5Min = (int)value;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_10_MIN:
                    m_genTickShortTermVolume10Min = (int)value;
                    break;
            }
        }

        public Object GetValue(string topicStr)
        {
            Object value = null;
            switch (topicStr)
            {
                case TwsRtdServerData.LAST:
                    value = m_lastPrice;
                    break;
                case TwsRtdServerData.BID:
                    value = m_bidPrice;
                    break;
                case TwsRtdServerData.ASK:
                    value = m_askPrice;
                    break;
                case TwsRtdServerData.LASTSIZE:
                    value = m_lastSize;
                    break;
                case TwsRtdServerData.ASKSIZE:
                    value = m_askSize;
                    break;
                case TwsRtdServerData.BIDSIZE:
                    value = m_bidSize;
                    break;
                case TwsRtdServerData.HIGH:
                    value = m_high;
                    break;
                case TwsRtdServerData.LOW:
                    value = m_low;
                    break;
                case TwsRtdServerData.OPEN:
                    value = m_open;
                    break;
                case TwsRtdServerData.CLOSE:
                    value = m_close;
                    break;
                case TwsRtdServerData.HALTED:
                    value = m_halted;
                    break;
                case TwsRtdServerData.VOLUME:
                    value = m_volume;
                    break;
                case TwsRtdServerData.BIDEXCH:
                    value = m_bidExch;
                    break;
                case TwsRtdServerData.ASKEXCH:
                    value = m_askExch;
                    break;
                case TwsRtdServerData.LASTEXCH:
                    value = m_lastExch;
                    break;
                case TwsRtdServerData.LASTTIME:
                    value = m_lastTime;
                    break;

                // generic ticks
                case TwsRtdServerData.GEN_TICK_AUCTION_VOLUME:
                    value = m_genTickAuctionVolume;
                    break;
                case TwsRtdServerData.GEN_TICK_AUCTION_IMBALANCE:
                    value = m_genTickAuctionImbalance;
                    break;
                case TwsRtdServerData.GEN_TICK_AUCTION_PRICE:
                    value = m_genTickAuctionPrice;
                    break;
                case TwsRtdServerData.GEN_TICK_REGULATORY_IMBALANCE:
                    value = m_genTickRegulatoryImbalance;
                    break;
                case TwsRtdServerData.GEN_TICK_PL_PRICE:
                    value = m_genTickPlPrice;
                    break;
                case TwsRtdServerData.GEN_TICK_CREDITMAN_MARK_PRICE:
                    value = m_genTickCreditmanMarkPrice;
                    break;
                case TwsRtdServerData.GEN_TICK_CREDITMAN_SLOW_MARK_PRICE:
                    value = m_genTickCreditmanSlowMarkPrice;
                    break;
                case TwsRtdServerData.GEN_TICK_CALL_OPTION_VOLUME:
                    value = m_genTickCallOptionVolume;
                    break;
                case TwsRtdServerData.GEN_TICK_PUT_OPTION_VOLUME:
                    value = m_genTickPutOptionVolume;
                    break;
                case TwsRtdServerData.GEN_TICK_CALL_OPTION_OPEN_INTEREST:
                    value = m_genTickCallOptionOpenInterest;
                    break;
                case TwsRtdServerData.GEN_TICK_PUT_OPTION_OPEN_INTEREST:
                    value = m_genTickPutOptionOpenInterest;
                    break;
                case TwsRtdServerData.GEN_TICK_OPTION_HISTORICAL_VOL:
                    value = m_genTickOptionHistoricalVol;
                    break;
                case TwsRtdServerData.GEN_TICK_RT_HISTORICAL_VOL:
                    value = m_genTickRTHistoricalVol;
                    break;
                case TwsRtdServerData.GEN_TICK_INDEX_FUTURE_PREMIUM:
                    value = m_genTickIndexFuturePremium;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORTABLE:
                    value = m_genTickShortable;
                    break;
                case TwsRtdServerData.GEN_TICK_FUNDAMENTALS:
                    value = m_genTickFundamentals;
                    break;
                case TwsRtdServerData.GEN_TICK_TRADE_COUNT:
                    value = m_genTickTradeCount;
                    break;
                case TwsRtdServerData.GEN_TICK_TRADE_RATE:
                    value = m_genTickTradeRate;
                    break;
                case TwsRtdServerData.GEN_TICK_VOLUME_RATE:
                    value = m_genTickVolumeRate;
                    break;
                case TwsRtdServerData.GEN_TICK_LAST_RTH_TRADE:
                    value = m_genTickLastRTHTrade;
                    break;
                case TwsRtdServerData.GEN_TICK_IB_DIVIDENDS:
                    value = m_genTickIBDividends;
                    break;
                case TwsRtdServerData.GEN_TICK_BOND_MULTIPLIER:
                    value = m_genTickBondMultiplier;
                    break;
                case TwsRtdServerData.GEN_TICK_AVERAGE_VOLUME:
                    value = m_genTickAverageVolume;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_13_HI:
                    value = m_genTickWeek13Hi;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_13_LO:
                    value = m_genTickWeek13Lo;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_26_HI:
                    value = m_genTickWeek26Hi;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_26_LO:
                    value = m_genTickWeek26Lo;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_52_HI:
                    value = m_genTickWeek52Hi;
                    break;
                case TwsRtdServerData.GEN_TICK_WEEK_52_LO:
                    value = m_genTickWeek52Lo;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_3_MIN:
                    value = m_genTickShortTermVolume3Min;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_5_MIN:
                    value = m_genTickShortTermVolume5Min;
                    break;
                case TwsRtdServerData.GEN_TICK_SHORT_TERM_VOLUME_10_MIN:
                    value = m_genTickShortTermVolume10Min;
                    break;
            }
            return value;
        }



    }
}