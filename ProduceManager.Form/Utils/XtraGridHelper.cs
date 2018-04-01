/*修改日志
 * 2012年7月21日   王怀生     添加
 * 2013年7月19日   邓千军     添加禁用GridView列排序，向Grid注册提示信息，在主从视图展开/折叠所有主视图的行，在列头添加一个复选框等方法
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Controls;
using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using ProduceManager.Form.Domains;

namespace ProduceManager.Form.Utils
{
    /// <summary>
    /// XtraGrid辅助类
    /// </summary>
    public partial class XtraGridHelper
    {

        /// <summary>
        /// 行号
        /// </summary>
        public static void DrawRowIndicator(GridView view)
        {
            view.IndicatorWidth = 40;
            view.CustomDrawRowIndicator += (object sender, RowIndicatorCustomDrawEventArgs e) =>
                {
                    if (e.Info.IsRowIndicator && e.RowHandle >= 0)
                    {
                        e.Info.DisplayText = (e.RowHandle + 1).ToString();
                    }
                };
        }

        /// <summary>
        /// 取Grid选中数据
        /// </summary>
        public static T GetSelectData<T>(GridView view) where T : class
        {
            if (view.FocusedRowHandle >= 0)
            {
                return view.GetRow(view.FocusedRowHandle) as T;
            }
            return default(T);
        }

        /// <summary>
        /// 设置gridview格式
        /// </summary>
        public static void SetGridViewStyle(GridView gridView, bool autoWidth, bool showBorder, params GridColumn[] allowEditColumns)
        {
            SetGridViewStyle(gridView, autoWidth, showBorder);
            if (allowEditColumns != null && allowEditColumns.Length > 0)
            {
                foreach (DevExpress.XtraGrid.Columns.GridColumn item in allowEditColumns)
                {
                    if (gridView.Columns.Contains(item))
                    {
                        item.OptionsColumn.AllowEdit = true;
                    }
                }
            }
        }

        /// <summary>
        /// 设置gridview格式
        /// </summary>
        public static void SetGridViewStyle(GridView gridView, bool autoWidth, bool showBorder)
        {
            SetGridViewStyle(gridView);
            gridView.OptionsView.ColumnAutoWidth = autoWidth;
            gridView.BorderStyle = showBorder ? BorderStyles.Default : BorderStyles.NoBorder;
        }

        /// <summary>
        /// 设置gridview格式
        /// </summary>
        public static void SetGridViewStyle(GridView gridView, params GridColumn[] allowEditColumns)
        {
            SetGridViewStyle(gridView);
            foreach (GridColumn column in allowEditColumns)
            {
                column.OptionsColumn.AllowEdit = true;
            }
        }

        /// <summary>
        /// 设置gridview格式
        /// </summary>
        public static void SetGridViewStyle(GridView gridView, bool allowEdit)
        {
            SetGridViewStyle(gridView);
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowEdit = allowEdit;
                column.OptionsColumn.AllowShowHide = allowEdit;
            }
        }

        /// <summary>
        /// 设置gridview格式
        /// </summary>
        public static void SetGridViewStyle(GridView gridView)
        {
            gridView.OptionsMenu.EnableColumnMenu = false;
            gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            gridView.OptionsView.ShowGroupPanel = false;
            gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            gridView.OptionsCustomization.AllowFilter = false;
            gridView.OptionsMenu.EnableColumnMenu = false;
            gridView.OptionsDetail.EnableMasterViewMode = false;
            gridView.OptionsView.EnableAppearanceEvenRow = true;
            gridView.OptionsView.EnableAppearanceOddRow = true;
            foreach (DevExpress.XtraGrid.Columns.GridColumn item in gridView.Columns)
            {
                item.OptionsColumn.AllowEdit = false;
                item.OptionsColumn.AllowShowHide = false;
            }
        }
        /// <summary>
        /// 固定列宽
        /// </summary>
        /// <param name="column">列</param>
        /// <param name="width">宽度</param>
        public static void FixColumnWidth(GridColumn column, int width)
        {
            column.MaxWidth = column.MinWidth = column.Width = width;
        }

        /// <summary>
        /// 固定列宽
        /// </summary>
        /// <param name="column">列</param>
        /// <param name="width">宽度</param>
        public static void AutoColumnWidth(GridColumn column, int width)
        {
            column.MaxWidth = 0;
            column.MinWidth = 0;
            column.Width = width;
        }

        /// <summary>
        /// 预处理Filter字符串，这里主要是因为Grid控件本身的Bug导致的
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string PreHandleFiterText(string text)
        {
            if (!string.IsNullOrEmpty(text) && (text.Contains('-') || text.Contains('+')))
            {
                text = text.Trim();
                text = text.Replace("-", "");
                text = text.Replace("+", "");
            }
            return text;
        }

        /// <summary>
        /// 居中文字
        /// </summary>
        /// <param name="column">列</param>
        /// <param name="centerHeader">列头居中否</param>
        /// <param name="centerCell">列单元格居中否</param>
        public static void CenterText(GridColumn column, bool centerHeader, bool centerCell)
        {
            if (centerCell)
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
            }
            if (centerHeader)
            {
                column.AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            }
        }

        /// <summary>
        /// 绑定CtrlC
        /// </summary>
        /// <param name="gridControl"></param>
        /// <param name="columns"></param>
        public static void BindCopyToCtrlC(GridControl gridControl, params GridColumn[] columns)
        {
            gridControl.KeyDown += (object sender, KeyEventArgs e) =>
                {
                    if (e.Control && e.KeyValue == 67)
                    {
                        GridControl gc = sender as GridControl;

                        if (gc != null && gc.Focused)
                        {
                            GridView gv = gc.FocusedView as GridView;
                            if (gv != null)
                            {
                                if (columns == null || columns.Length == 0)
                                {
                                    CopyTextToClipboard(gv);
                                }
                                else if (columns != null && columns.Length > 0 && columns.Contains(gv.FocusedColumn))
                                {
                                    CopyTextToClipboard(gv);
                                }
                                else
                                {
                                    Clipboard.Clear();
                                }
                                e.Handled = true;
                            }
                        }
                    }
                };
        }

        private static void CopyTextToClipboard(GridView gv)
        {
            object val = gv.GetFocusedValue();
            string str = (val ?? "").ToString();
            if (!string.IsNullOrEmpty(str) && !(val is Bitmap))
            {
                Clipboard.SetText(str);
            }
            else
            {
                Clipboard.Clear();
            }
        }

        /// <summary>
        /// 选中GridView对应Key的行,如果不存在则选中第一行
        /// </summary>
        /// <param name="gv">GridView控件</param>
        /// <param name="key">要选中的Key</param>
        public static void SelectXtraGridRow(GridView gv, Entity key)
        {
            SelectXtraGridRow(gv, key == null ? null : key.Id.ToString());
        }

        /// <summary>
        /// 选中GridView对应Key的行,如果不存在则选中第一行
        /// </summary>
        /// <param name="gv">GridView控件</param>
        /// <param name="keyToSelect">要选中的Key</param>
        public static void SelectXtraGridRow(GridView gv, string keyToSelect)
        {
            if (gv == null)
                return;

            if (!string.IsNullOrEmpty(keyToSelect))
            {
                for (int i = 0; i < gv.RowCount; i++)
                {
                    var rowInfo = gv.GetRow(i) as Entity;
                    if (rowInfo != null && rowInfo.Id.ToString().Equals(keyToSelect))
                    {
                        gv.FocusedRowHandle = i;
                        return;
                    }
                }
            }

            if (gv.RowCount > 0)
                gv.FocusedRowHandle = 0;
        }

        /// <summary>
        /// 向Grid注册单元格中的提示信息
        ///    用户可根据表格，列，行来指定提示内容
        /// </summary>
        /// <param name="gridControl">要注册的Grid</param>
        /// <param name="showTipsCondition">显示提示信息的条件</param>
        /// <param name="getCellHintText">获取显示文本的委托</param>
        /// <param name="getCellHintTitle">获取显示标题的委托，如果为空则显示列标题</param>
        public static void RegisteGridCellHint(GridControl gridControl, Func<GridHitInfo, bool> showTipsCondition, Func<GridView, int, GridColumn, string> getCellHintText, Func<GridView, int, GridColumn, string> getCellHintTitle = null)
        {
            if (gridControl == null)
                throw new ArgumentNullException("gridControl");
            if (showTipsCondition == null)
                throw new ArgumentNullException("showTipsCondition");
            if (getCellHintText == null)
                throw new ArgumentNullException("getCellHintText");

            ToolTipController toolTipController = gridControl.ToolTipController;
            if (toolTipController == null)
            {
                toolTipController = new ToolTipController();
                toolTipController.ToolTipType = ToolTipType.SuperTip;
                gridControl.ToolTipController = toolTipController;
            }

            toolTipController.GetActiveObjectInfo += (object sender, DevExpress.Utils.ToolTipControllerGetActiveObjectInfoEventArgs e) =>
            {
                if (e.SelectedControl != gridControl) return;
                ToolTipControlInfo info = e.Info;
                try
                {
                    GridView view = gridControl.GetViewAt(e.ControlMousePosition) as GridView;
                    if (view == null)
                        return;

                    GridHitInfo hi = view.CalcHitInfo(e.ControlMousePosition);
                    if (hi.InRowCell && showTipsCondition(hi))
                    {
                        var hintText = getCellHintText(view, hi.RowHandle, hi.Column);
                        var hintTitle = getCellHintTitle == null ? hi.Column.Caption : getCellHintTitle(view, hi.RowHandle, hi.Column);
                        info = new ToolTipControlInfo(new CellToolTipInfo(hi.RowHandle, hi.Column, "cell"), hintText, hintTitle);
                    }
                }
                finally
                {
                    e.Info = info;
                }
            };
        }

        /// <summary>
        /// 向Grid注册提示信息
        /// </summary>
        /// <typeparam name="TEntity">grid绑定的实体类型</typeparam>
        /// <param name="gridControl">要注册的Grid</param>
        /// <param name="showTipsCondition">显示提示信息的条件</param>
        /// <param name="getCellHintText">获取显示文本的委托</param>
        /// <param name="getCellHintTitle">获取显示标题的委托，如果为空则显示列标题</param>
        public static void RegisteGridCellHint<TEntity>(GridControl gridControl, Func<GridHitInfo, bool> showTipsCondition, Func<TEntity, string> getCellHintText, Func<GridView, int, GridColumn, string> getCellHintTitle = null) where TEntity : class
        {
            RegisteGridCellHint(gridControl, showTipsCondition,
                (view, rowHandler, column) => getCellHintText(view.GetRow(rowHandler) as TEntity),
                getCellHintTitle
                );
        }

        /// <summary>
        /// 设置Grid的列排序是否启用，默认禁用
        /// </summary>
        /// <param name="gridView">表格</param>
        /// <param name="enableSortColumns">设置为启用排序的列</param>
        public static void SetSortable(GridView gridView, params GridColumn[] enableSortColumns)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                column.OptionsColumn.AllowSort = DefaultBoolean.False;
            }

            foreach (GridColumn column in enableSortColumns)
            {
                column.OptionsColumn.AllowSort = DefaultBoolean.True;
            }
        }

        /// <summary>
        /// 在主从视图展开/折叠所有主视图的行
        /// </summary>
        /// <param name="gridView">表格</param>
        /// <param name="expand">是否展开</param>
        public static void SetAllMasterRowExpand(GridView gridView, bool expand)
        {
            gridView.BeginUpdate();
            try
            {
                int dataRowCount = gridView.DataRowCount;
                for (int rowHandle = 0; rowHandle < dataRowCount; rowHandle++)
                    gridView.SetMasterRowExpanded(rowHandle, expand);
            }
            finally
            {
                gridView.EndUpdate();
            }
        }
    }
}