using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Paint;

namespace Gestion_Cabinet_Medical.Functions
{
    public class SelectedCellsBorderHelper
    {

        public SelectedCellsBorderHelper(GridView gridView)
        {
            _GridView = gridView;
            gridView.GridControl.PaintEx += GridControl_PaintEx;
        }

        private void GridControl_PaintEx(object sender, PaintExEventArgs e)
        {
            if (IsCopyMode)
                DrawCopyBorder(e);
            else
                DrawRegularBorder(e);
        }

        private bool _IsCopyMode;
        private GridView _GridView;
        public GridView GridView
        {
            get { return _GridView; }
            set { _GridView = value; }
        }


        private GridControl _GridControl;
        public GridControl GridControl
        {
            get { return _GridView.GridControl; }
        }

        public bool IsCopyMode
        {
            get { return _IsCopyMode; }
            set { _IsCopyMode = value; OnCopyModeChanged(); }
        }

        XPaint _paint = new XPaint();

        private XPaint Paint
        {
            get
            {
                return _paint;
            }
        }

        private int _DragRectSize = 6;
        int lineWidth = 3;


        private Rectangle GetSelectionBounds()
        {
            int width = 0;
            int height = 0;
            Rectangle rTop = Rectangle.Empty;
            bool shouldReturn = false;
            GridView view = GridControl.FocusedView as GridView;
            GridViewInfo info = view.GetViewInfo() as GridViewInfo;
            GridCell[] gridCells = view.GetSelectedCells();
            if (gridCells.Length == 0)
            {
                shouldReturn = true;
                return Rectangle.Empty;
            }
            Brush hb = Brushes.Black;
            List<GridCellInfo> visibleColl = new List<GridCellInfo>();
            foreach (GridRowInfo row in info.RowsInfo)
            {
                if (row is GridGroupRowInfo)
                {
                    continue;
                }
                GridCellInfoCollection coll = (row as GridDataRowInfo).Cells;
                foreach (GridCellInfo cell in coll)
                    visibleColl.Add(cell);

            }
            List<GridCellInfo> collection = new List<GridCellInfo>();
            foreach (GridCell cell in gridCells)
                foreach (GridCellInfo cellInfo in visibleColl)
                    if (cellInfo.RowInfo != null && cellInfo.ColumnInfo != null)
                        if (cell.RowHandle == cellInfo.RowHandle && cell.Column == cellInfo.Column)
                            collection.Add(cellInfo);
            if (collection.Count == 0)
            {
                shouldReturn = true;
                return Rectangle.Empty;
            }
            rTop = GetCellRect(view, collection[0].RowHandle, collection[0].Column);
            Rectangle rBottom = GetCellRect(view, collection[collection.Count - 1].RowHandle, collection[collection.Count - 1].Column);
            if (rTop.Y > rBottom.Y)
                height = rTop.Y - rBottom.Bottom;
            else
                height = rBottom.Bottom - rTop.Y;

            if (rTop.X <= rBottom.X)
                width = rBottom.Right - rTop.X;
            else
                width = rTop.X - rBottom.Right;
            return new Rectangle(rTop.X, rTop.Y, width, height);
        }

        private void DrawCopyBorder(PaintExEventArgs e)
        {
            Rectangle rect = GetSelectionBounds();
            Paint.DrawFocusRectangle(e.Cache.Graphics, rect, Color.Black, Color.White);
        }

        private void DrawRegularBorder(PaintExEventArgs e)
        {
            Rectangle rect = GetSelectionBounds();
            e.Cache.DrawRectangle(e.Cache.GetPen(Color.Black, lineWidth), rect);
            if (GridView.GetSelectedCells().Length == 1)
                DrawDragImage(e, rect);
        }

        public Rectangle GetDragRect()
        {
            return GetDragRect(GetSelectionBounds());
        }

        private Rectangle GetDragRect(Rectangle rect)
        {
            return new Rectangle(rect.Right - _DragRectSize, rect.Bottom - _DragRectSize, _DragRectSize, _DragRectSize);
        }
        private void DrawDragImage(PaintExEventArgs e, Rectangle rect)
        {
            e.Cache.FillRectangle(Brushes.Black, GetDragRect(rect));
        }
        Rectangle GetCellRect(GridView view, int rowHandle, GridColumn column)
        {
            GridViewInfo info = (GridViewInfo)view.GetViewInfo();
            GridCellInfo cell = info.GetGridCellInfo(rowHandle, column);
            if (cell != null)
                return cell.Bounds;
            return Rectangle.Empty;
        }
        private void OnCopyModeChanged()
        {
            GridView.InvalidateRow(GridView.FocusedRowHandle);
        }
    }
}
