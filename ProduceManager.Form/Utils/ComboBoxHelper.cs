/*修改日志
 * 2012年7月21日   王怀生         添加
 * 2012年7月23日   重写了该类     修改
 * 2013年6月6日    移除new约束class约束，对枚举添加struct约束    修改
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using System.Linq.Expressions;

namespace ProduceManager.Forms.Utils
{
    /// <summary>
    /// 下拉控件辅助类
    /// </summary>
    public static class ComboBoxExtension
    {


        /// <summary>
        /// 绑定对象列表到下拉框
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="ctr">下拉控件</param>
        /// <param name="datas">数据列表</param>
        /// <param name="displayFunc">取得显示文字方法</param>
        /// <param name="header">请选择等文字</param>
        public static void BindList<T>(this ComboBoxEdit ctr, IEnumerable<T> datas, Func<T, string> displayFunc, string header = null) where T : class
        {
            if (!string.IsNullOrEmpty(header))
            {
                ctr.Properties.Items.Add(header);
            }

            if (datas != null && datas.Any())
            {
                var bindDatas = datas
                    .Select(old => new IDTextData<T> { Data = old, Text = displayFunc(old) })
                    .ToList();
                ctr.Properties.Items.AddRange(bindDatas);
            }
            ctr.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            if (ctr.Properties.Items.Count > 0)
            {
                ctr.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 设置选中项
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="ctr">控件</param>
        /// <param name="data">数据</param>
        public static void SetSelectData<T>(this ComboBoxEdit ctr, T data) where T : class
        {
            foreach (var item in ctr.Properties.Items)
            {
                var itd = item as IDTextData<T>;
                if (itd != null && object.ReferenceEquals(itd.Data, data))
                {
                    ctr.SelectedItem = itd;
                }
            }
        }

        /// <summary>
        /// 获取选中项
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="ctr">控件</param>
        /// <returns>选中数据</returns>
        public static T GetSelectedItem<T>(this ComboBoxEdit ctr) where T : class
        {
            if (ctr.SelectedItem != null)
            {
                IDTextData<T> data = ctr.SelectedItem as IDTextData<T>;
                if (data != null)
                {
                    return data.Data;
                }
            }
            return default(T);
        }

        ///// <summary>
        ///// 绑定枚举到下拉框
        ///// </summary>
        ///// <param name="ctr">控件</param>
        ///// <param name="header">请选择等文字</param>
        ///// <param name="except">不绑定项</param>
        ///// <typeparam name="T">枚举类型</typeparam>
        //public static void BindEnumToCombo<T>(ComboBoxEdit ctr, string header = null, List<T> except = null) where T : struct
        //{
        //    Type t = typeof(T);
        //    if (!t.IsEnum)
        //    {
        //        throw new ArgumentException(t.FullName + "不是枚举类型");
        //    }
        //    if (!string.IsNullOrEmpty(header))
        //    {
        //        ctr.Properties.Items.Add(header);
        //    }
        //    List<EnumDescription> eds = EnumDescription.GetFieldInfos(typeof(T));
        //    if (eds != null && eds.Count > 0 && except != null && except.Count > 0)
        //    {
        //        List<int> exceptValue = except.Select(old => { return old.CastTo<int>(); }).ToList();
        //        foreach (EnumDescription ed in eds)
        //        {
        //            if (!exceptValue.Contains(ed.EnumValue))
        //            {
        //                ctr.Properties.Items.Add(ed);
        //            }
        //        }
        //    }
        //    else if (eds != null && eds.Count > 0)
        //    {
        //        ctr.Properties.Items.AddRange(eds);
        //    }
        //    ctr.Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        //    if (ctr.Properties.Items.Count > 0)
        //    {
        //        ctr.SelectedIndex = 0;
        //    }
        //}

        ///// <summary>
        ///// 设置选中项
        ///// </summary>
        ///// <typeparam name="T">类型</typeparam>
        ///// <param name="ctr">控件</param>
        ///// <param name="data">数据</param>
        //public static void SetSelectEnum<T>(ComboBoxEdit ctr, T data) where T : struct
        //{
        //    Type t = typeof(T);
        //    if (!t.IsEnum)
        //    {
        //        throw new ArgumentException(t.FullName + "必须是枚举类型");
        //    }
        //    else
        //    {
        //        foreach (var item in ctr.Properties.Items)
        //        {
        //            var ed = item as EnumDescription;
        //            if (ed != null && ed.EnumValue == data.CastTo<int>())
        //            {
        //                ctr.SelectedItem = ed;
        //            }
        //        }
        //    }
        //}

        ///// <summary>
        ///// 获取选中项
        ///// </summary>
        ///// <typeparam name="T">类型</typeparam>
        ///// <param name="ctr">控件</param>
        ///// <returns>选中数据</returns>
        //public static T GetSelectEnum<T>(ComboBoxEdit ctr) where T : struct
        //{
        //    Type t = typeof(T);
        //    if (!t.IsEnum)
        //    {
        //        throw new ArgumentException(t.FullName + "必须是枚举类型");
        //    }
        //    else
        //    {
        //        var ed = ctr.SelectedItem as EnumDescription;
        //        if (ed != null)
        //        {
        //            return (T)ed.EnumValue.CastTo<T>();
        //        }
        //    }
        //    return default(T);
        //}
    }

    public static class LooUpEditExtension
    {

        public static void BindList<T>(this LookUpEdit ctr, IEnumerable<T> datas, Expression<Func<T, String>> displayFunc) where T : class
        {
            var memberName = "";
            var xx = displayFunc.Body as MemberExpression;
            if (xx != null)
                memberName = xx.Member.Name;
            else
                throw new Exception(string.Format("Expression {0} was invalid", displayFunc.ToString()));

            var func = displayFunc.Compile();
            BindList(ctr, datas.Select(x => new ObjectDisplayPair<T> { DisplayText = func(x), Object = x }), memberName);
        }

        public static void BindList<T>(this LookUpEdit ctr, IEnumerable<T> datas, string displayMember) where T : class
        {
            if (string.IsNullOrWhiteSpace(displayMember))
                throw new Exception(string.Format("displayMember {0} was invalid", displayMember));

            ctr.Properties.DataSource = datas;
            ctr.Properties.DisplayMember = displayMember;
            ctr.Properties.ValueMember = "Object";

            if (datas != null && datas.Any())
                ctr.ItemIndex = 0;
        }

        public static void SetSelectItem<T>(this LookUpEdit ctr, T seletedItem) where T : class
        {
            ctr.EditValue = seletedItem;
        }
    }

    public class ObjectDisplayPair<T>
    {
        public string DisplayText { get; set; }

        public T Object { get; set; }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return DisplayText;
        }
    }
}