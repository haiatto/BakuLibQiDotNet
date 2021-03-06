﻿using System;
using System.Runtime.InteropServices;

namespace Baku.LibqiDotNet.QiApi
{
    /// <summary>アンマネージドAPIのうち<see cref="QiObjectBuilder"/>に関するもの</summary>
    internal static class QiApiObjectBuilder
    {
        #region dllimport
        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr qi_object_builder_create();

        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern void qi_object_builder_destroy(IntPtr qiObj);

        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern uint qi_object_builder_advertise_method(
            IntPtr qiObjBuilder, string completeSignature, QiApiObjectMethod function, IntPtr userdata
            );

        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern uint qi_object_builder_advertise_signal(
            IntPtr qiObjBuilder, string name, string signature
            );

        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern uint qi_object_builder_advertise_property(
            IntPtr qiObjBuilder, string name, string signature
            );

        [DllImport(DllImportSettings.DllName, CallingConvention = CallingConvention.Cdecl)]
        private static extern IntPtr qi_object_builder_get_object(IntPtr qiObjBuilder);

        #endregion

        internal static QiObjectBuilder Create() => new QiObjectBuilder(qi_object_builder_create());

        internal static void DestroyBuilder(QiObjectBuilder objBuilder)
            => qi_object_builder_destroy(objBuilder.Handle);

        internal static uint AdvertiseMethod(
            QiObjectBuilder objBuilder,
            string completeSignature,
            QiApiObjectMethod method,
            IntPtr userdata
            )
            => qi_object_builder_advertise_method(objBuilder.Handle, completeSignature, method, userdata);

        internal static uint AdvertiseSignal(QiObjectBuilder objBuilder, string name, string signature)
            => qi_object_builder_advertise_signal(objBuilder.Handle, name, signature);

        internal static uint AdvertiseProperty(QiObjectBuilder objBuilder, string name, string signature)
            => qi_object_builder_advertise_property(objBuilder.Handle, name, signature);

        internal static QiObject BuildObject(QiObjectBuilder objBuilder)
            => new QiObject(qi_object_builder_get_object(objBuilder.Handle));

    }

    internal delegate void QiApiObjectMethod(string completeSignature, IntPtr msg, IntPtr ret, IntPtr userdata);
}
