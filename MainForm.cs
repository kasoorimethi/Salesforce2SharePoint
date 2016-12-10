using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salesforce2SharePoint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: このコード行はデータを 'sharePointDataSet.Salesforce予定表' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.salesforce予定表TableAdapter.Fill(this.sharePointDataSet.Salesforce予定表);
            // TODO: このコード行はデータを 'salesforceDataSet.Event' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
            this.eventTableAdapter.Fill(this.salesforceDataSet.Event);
        }

        private void btImport_Click(object sender, EventArgs e)
        {
            var sharePointMap = this.dgvDestination.Rows
                .Cast<DataGridViewRow>()
                .Select(o => (SharePointDataSet.Salesforce予定表Row)((DataRowView)o.DataBoundItem).Row)
                .ToDictionary(o => o.タイトル, o => o);


            var selectedList = this.dgvSource.Rows.Cast<DataGridViewRow>()
                .Where(o => o.Selected)
                .Select(o => (SalesforceDataSet.EventRow)((DataRowView)o.DataBoundItem).Row)
                .ToList();

            var dummyId = 0;

            foreach (var selected in selectedList)
            {
                if (sharePointMap.ContainsKey(selected.Subject))
                {
                    continue;
                }

                var newRow = this.sharePointDataSet.Salesforce予定表.NewSalesforce予定表Row();

                newRow.ID = dummyId++;
                newRow.タイトル3 = selected.Subject;
                newRow.開始時刻 = selected.StartDateTime;
                newRow.終了時刻 = selected.EndDateTime;
                newRow.場所 = selected.IsLocationNull() ? "" : selected.Location;
                newRow.終日 = selected.IsAllDayEvent ? "1" : "0";
                newRow.説明 = selected.IsDescriptionNull() ? "" : selected.Description;

                this.sharePointDataSet.Salesforce予定表.AddSalesforce予定表Row(newRow);
            }

            this.salesforce予定表TableAdapter.Update(this.sharePointDataSet.Salesforce予定表);
            this.salesforce予定表TableAdapter.Fill(this.sharePointDataSet.Salesforce予定表);
        }
    }
}
