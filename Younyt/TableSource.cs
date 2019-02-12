using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using Younyt.Model;

namespace Younyt
{
    public class TableSource : UITableViewSource
    {
        List<AvatarDetails> avatarDetails;

        public TableSource(List<AvatarDetails> details)
        {
            avatarDetails = details;
        }
        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            //var cell = tableView.DequeueReusableCell(CellIdentifier);
            //string item = TableItems[indexPath.Row];
            //if (cell == null)
            //{
            //    cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
            //    //cell = new tableViewCell();                                
            //}
            //cell.TextLabel.Text = item;

            var cell = (CustomHomeTabCell)tableView.DequeueReusableCell("cell_id", indexPath);
            var item = avatarDetails[indexPath.Row];
            cell.UpdateCell(item);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return avatarDetails.Count;
        }
    }
}