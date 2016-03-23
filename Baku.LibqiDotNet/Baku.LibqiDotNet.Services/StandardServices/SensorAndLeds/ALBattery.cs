using System;
using System.Collections.Generic;
using System.Linq;

namespace Baku.LibqiDotNet.Service
{
    /// <summary>Deals with Battery informations.A event name BatteryChargeCellVoltageMinChanged is raised when the cell voltage Min (int) of the battery changed.A event name BatteryChargingFlagChanged is raised when the flag battery is charging (bool) changed.A event name BatteryFullChargedFlagChanged is raised when the flag battery is full charged (bool) changed.A event name BatteryDisChargingFlagChanged is raised when the flag battery is disCharging (bool) changed.A event name BatteryChargeChanged is raised when the battery level percentage (int) changed.</summary>
    public class ALBattery
    {
        /// <summary>サービスの取得元セッションを指定してサービスを初期化します。</summary>
        /// <param name="session">サービスの取得元となるセッション</param>
        public ALBattery(QiSession session)
        {
            SourceService = session.GetService("ALBattery");
        }

        /// <summary>コード生成によってラップされる前のサービスオブジェクトを取得します。</summary>
        public QiObject SourceService { get; }


        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
        public ulong RegisterEvent(uint arg0, uint arg1, ulong arg2)
        {
            return (ulong)SourceService["registerEvent"].Call(arg0, arg1, arg2);
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <returns></returns>
        public void UnregisterEvent(uint arg0, uint arg1, ulong arg2)
        {
            SourceService["unregisterEvent"].Call(arg0, arg1, arg2);
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public QiValue MetaObject(uint arg0)
        {
            return SourceService["metaObject"].Call(arg0);
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public void Terminate(uint arg0)
        {
            SourceService["terminate"].Call(arg0);
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public QiValue Property(QiAnyValue arg0)
        {
            return SourceService["property"].Call(arg0);
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <returns></returns>
        public void SetProperty(QiAnyValue arg0, QiAnyValue arg1)
        {
            SourceService["setProperty"].Call(arg0, arg1);
        }

        /// <summary></summary>
		/// <returns></returns>
        public string[] Properties()
        {
            return (string[])SourceService["properties"].Call();
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <param name="arg2"></param>
		/// <param name="arg3"></param>
		/// <returns></returns>
        public ulong RegisterEventWithSignature(uint arg0, uint arg1, ulong arg2, string arg3)
        {
            return (ulong)SourceService["registerEventWithSignature"].Call(arg0, arg1, arg2, arg3);
        }

        /// <summary></summary>
		/// <returns></returns>
        public bool IsStatsEnabled()
        {
            return (bool)SourceService["isStatsEnabled"].Call();
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public void EnableStats(bool arg0)
        {
            SourceService["enableStats"].Call(arg0);
        }

        /// <summary></summary>
		/// <returns></returns>
        public QiValue Stats()
        {
            return SourceService["stats"].Call();
        }

        /// <summary></summary>
		/// <returns></returns>
        public void ClearStats()
        {
            SourceService["clearStats"].Call();
        }

        /// <summary></summary>
		/// <returns></returns>
        public bool IsTraceEnabled()
        {
            return (bool)SourceService["isTraceEnabled"].Call();
        }

        /// <summary></summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public void EnableTrace(bool arg0)
        {
            SourceService["enableTrace"].Call(arg0);
        }

        /// <summary>Exits and unregisters the module.</summary>
		/// <returns></returns>
        public void Exit()
        {
            SourceService["exit"].Call();
        }

        /// <summary>Internal function to pCall methods</summary>
		/// <param name="arg0"></param>
		/// <param name="arg1"></param>
		/// <returns></returns>
        public int __pCall(uint arg0, QiAnyValue arg1)
        {
            return (int)SourceService["__pCall"].Call(arg0, arg1);
        }

        /// <summary>NAOqi1 pCall method.</summary>
		/// <param name="arg0"></param>
		/// <returns></returns>
        public QiValue PCall(QiAnyValue arg0)
        {
            return SourceService["pCall"].Call(arg0);
        }

        /// <summary>Returns the version of the module.</summary>
		/// <returns>A string containing the version of the module.</returns>
        public string Version()
        {
            return (string)SourceService["version"].Call();
        }

        /// <summary>Just a ping. Always returns true</summary>
		/// <returns>returns true</returns>
        public bool Ping()
        {
            return (bool)SourceService["ping"].Call();
        }

        /// <summary>Retrieves the module's method list.</summary>
		/// <returns>An array of method names.</returns>
        public string[] GetMethodList()
        {
            return (string[])SourceService["getMethodList"].Call();
        }

        /// <summary>Retrieves a method's description.</summary>
		/// <param name="arg0_methodName">The name of the method.</param>
		/// <returns>A structure containing the method's description.</returns>
        public QiValue GetMethodHelp(string arg0_methodName)
        {
            return SourceService["getMethodHelp"].Call(arg0_methodName);
        }

        /// <summary>Retrieves the module's description.</summary>
		/// <returns>A structure describing the module.</returns>
        public QiValue GetModuleHelp()
        {
            return SourceService["getModuleHelp"].Call();
        }

        /// <summary>Wait for the end of a long running method that was called using 'post'</summary>
		/// <param name="arg0_id">The ID of the method that was returned when calling the method using 'post'</param>
		/// <param name="arg1_timeoutPeriod">The timeout period in ms. To wait indefinately, use a timeoutPeriod of zero.</param>
		/// <returns>True if the timeout period terminated. False if the method returned.</returns>
        public bool Wait(int arg0_id, int arg1_timeoutPeriod)
        {
            return (bool)SourceService["wait"].Call(arg0_id, arg1_timeoutPeriod);
        }

        /// <summary>Wait for the end of a long running method that was called using 'post', returns a cancelable future</summary>
		/// <param name="arg0_id">The ID of the method that was returned when calling the method using 'post'</param>
		/// <returns></returns>
        public void Wait(int arg0_id)
        {
            SourceService["wait"].Call(arg0_id);
        }

        /// <summary>Returns true if the method is currently running.</summary>
		/// <param name="arg0_id">The ID of the method that was returned when calling the method using 'post'</param>
		/// <returns>True if the method is currently running</returns>
        public bool IsRunning(int arg0_id)
        {
            return (bool)SourceService["isRunning"].Call(arg0_id);
        }

        /// <summary>returns true if the method is currently running</summary>
		/// <param name="arg0_id">the ID of the method to wait for</param>
		/// <returns></returns>
        public void Stop(int arg0_id)
        {
            SourceService["stop"].Call(arg0_id);
        }

        /// <summary>Gets the name of the parent broker.</summary>
		/// <returns>The name of the parent broker.</returns>
        public string GetBrokerName()
        {
            return (string)SourceService["getBrokerName"].Call();
        }

        /// <summary>Gets the method usage string. This summarises how to use the method.</summary>
		/// <param name="arg0_name">The name of the method.</param>
		/// <returns>A string that summarises the usage of the method.</returns>
        public string GetUsage(string arg0_name)
        {
            return (string)SourceService["getUsage"].Call(arg0_name);
        }

        /// <summary>Enable power monitoring</summary>
		/// <param name="arg0_Enable">True activate power monitoring</param>
		/// <returns></returns>
        public void EnablePowerMonitoring(bool arg0_Enable)
        {
            SourceService["enablePowerMonitoring"].Call(arg0_Enable);
        }

        /// <summary>Get the battery charge in percents</summary>
		/// <returns>the percentage of remaining power</returns>
        public int GetBatteryCharge()
        {
            return (int)SourceService["getBatteryCharge"].Call();
        }

        /// <summary>Internal set the battery level for the first warning.</summary>
		/// <param name="arg0_Percent">Percentage of battery.</param>
		/// <returns></returns>
        public void _setFirstWarningPercent(int arg0_Percent)
        {
            SourceService["_setFirstWarningPercent"].Call(arg0_Percent);
        }

        /// <summary>Internal set the battery level for the second warning.</summary>
		/// <param name="arg0_Percent">Percentage of battery.</param>
		/// <returns></returns>
        public void _setWarningPercent(int arg0_Percent)
        {
            SourceService["_setWarningPercent"].Call(arg0_Percent);
        }

        /// <summary>Internal set the battery level for the last warning.</summary>
		/// <param name="arg0_Percent">Percentage of battery.</param>
		/// <returns></returns>
        public void _setLastWarningPercent(int arg0_Percent)
        {
            SourceService["_setLastWarningPercent"].Call(arg0_Percent);
        }

        /// <summary>Is battery detected.</summary>
		/// <returns>Return true if battery is detected.</returns>
        public bool _hasBattery()
        {
            return (bool)SourceService["_hasBattery"].Call();
        }

        /// <summary>Get current battery mode.</summary>
		/// <returns>Return the current battery mode. (Local = 0, robot = 1, simulation = 2)</returns>
        public int _getBatteryMode()
        {
            return (int)SourceService["_getBatteryMode"].Call();
        }

        /// <summary>Get current battery fully charged threshold.</summary>
		/// <returns>the percentage of threshold for fully charged event.</returns>
        public int _getFullyChargedThreshold()
        {
            return (int)SourceService["_getFullyChargedThreshold"].Call();
        }

        /// <summary>Set battery fully charged threshold.</summary>
		/// <param name="arg0_threshold">the percentage of threshold for fully charged event.</param>
		/// <returns></returns>
        public void _setFullyChargedThreshold(int arg0_threshold)
        {
            SourceService["_setFullyChargedThreshold"].Call(arg0_threshold);
        }

        /// <summary>Set mode slave status.</summary>
		/// <param name="arg0_status">Enables or disables mode slave.</param>
		/// <returns></returns>
        public void _setModeSlave(bool arg0_status)
        {
            SourceService["_setModeSlave"].Call(arg0_status);
        }

    }
}