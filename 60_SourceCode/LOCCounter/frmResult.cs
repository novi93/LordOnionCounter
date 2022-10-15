using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MS.IT.LOC.CounterEngine;
using MS.IT.LOC.Manager;
using MS.IT.LOC.Model;

namespace MS.IT.LOC.UI
{
    // Token: 0x02000024 RID: 36
    public partial class frmResult : Form
    {
        // Token: 0x060001DB RID: 475 RVA: 0x00014AF6 File Offset: 0x00013AF6
        public frmResult(CounterItemSet CISet)
        {
            this.InitializeComponent();
            this.CISet = CISet;
        }

        // Token: 0x060001DC RID: 476 RVA: 0x00014B18 File Offset: 0x00013B18
        private void ShowListViewPspMetrics()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CountResultPspSummary.Rows.Count];
            for (int i = 0; i < this.objResult.CountResultPspSummary.Rows.Count; i++)
            {
                if (a != this.objResult.CountResultPspSummary.Rows[i][0].ToString())
                {
                    a = this.objResult.CountResultPspSummary.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CountResultPspSummary.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewPspSummary.Groups.Add(group);
                }
                long num = (long)this.objResult.CountResultPspSummary.Rows[i]["Added"] + (long)this.objResult.CountResultPspSummary.Rows[i]["Modified"];
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CountResultPspSummary.Rows[i][2].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][3].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][4].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][5].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][6].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][7].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][8].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][9].ToString(),
                    this.objResult.CountResultPspSummary.Rows[i][10].ToString(),
                    num.ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewPspSummary.Items.AddRange(array);
            array = new ListViewItem[this.objResult.CountResultPspDetails.Rows.Count];
            a = "";
            for (int i = 0; i < this.objResult.CountResultPspDetails.Rows.Count; i++)
            {
                if (a != this.objResult.CountResultPspDetails.Rows[i][0].ToString())
                {
                    a = this.objResult.CountResultPspDetails.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CountResultPspDetails.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewPspDetails.Groups.Add(group);
                }
                long num = (long)this.objResult.CountResultPspDetails.Rows[i]["Added"] + (long)this.objResult.CountResultPspDetails.Rows[i]["Modified"];
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CountResultPspDetails.Rows[i][2].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][3].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][4].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][5].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][6].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][7].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][8].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][9].ToString(),
                    this.objResult.CountResultPspDetails.Rows[i][10].ToString(),
                    num.ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewPspDetails.Items.AddRange(array);
        }

        // Token: 0x060001DD RID: 477 RVA: 0x000150BC File Offset: 0x000140BC
        private void ShowListViewFileItem()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CounterResultData.Rows.Count];
            for (int i = 0; i < this.objResult.CounterResultData.Rows.Count; i++)
            {
                if (a != this.objResult.CounterResultData.Rows[i][0].ToString())
                {
                    a = this.objResult.CounterResultData.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CounterResultData.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.lvWItems.Groups.Add(group);
                }
                int num = Convert.ToInt32(this.objResult.CounterResultData.Rows[i][4]) + Convert.ToInt32(this.objResult.CounterResultData.Rows[i][5]);
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CounterResultData.Rows[i][2].ToString(),
                    this.objResult.CounterResultData.Rows[i][3].ToString(),
                    this.objResult.CounterResultData.Rows[i][4].ToString(),
                    this.objResult.CounterResultData.Rows[i][5].ToString(),
                    this.objResult.CounterResultData.Rows[i][6].ToString(),
                    num.ToString()
                })
                {
                    Group = group
                };
            }
            this.lvWItems.Items.AddRange(array);
        }

        // Token: 0x060001DE RID: 478 RVA: 0x000152F4 File Offset: 0x000142F4
        private void InitDataSetPspSummary()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CounterItemID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("FilePath", typeof(string));
            dataTable.Columns.Add("TagType", typeof(string));
            dataTable.Columns.Add("TagValue", typeof(string));
            dataTable.Columns.Add("ObjectType", typeof(string));
            dataTable.Columns.Add("Elements", typeof(long));
            dataTable.Columns.Add("Base", typeof(long));
            dataTable.Columns.Add("Added", typeof(long));
            dataTable.Columns.Add("Modified", typeof(long));
            dataTable.Columns.Add("Deleted", typeof(long));
            foreach (object obj in this.CISet)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount && counterItem.PspMetrics)
                {
                    dataTable.Rows.Clear();
                    foreach (LineCounter lineCounter in ((CodeCounter)counterItem.PspMetricHash["PspMetric"]).LineCounters)
                    {
                        foreach (object obj2 in lineCounter.PspMetricFileHash)
                        {
                            DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
                            string text = dictionaryEntry.Key.ToString();
                            try
                            {
                                text = text.Substring(text.LastIndexOf("\\") + 1);
                                text = text.Substring(37);
                            }
                            catch
                            {
                                text = "";
                            }
                            foreach (object obj3 in ((PspMetricFileData)dictionaryEntry.Value).pspMetricCounterDataSet)
                            {
                                PspMetricCounterData pspMetricCounterData = (PspMetricCounterData)obj3;
                                if (pspMetricCounterData.itemCount != 0)
                                {
                                    DataRow dataRow = dataTable.NewRow();
                                    dataRow[0] = counterItem.CounterItemID;
                                    dataRow[1] = counterItem.Name;
                                    dataRow[2] = "./" + text;
                                    dataRow[3] = pspMetricCounterData.PspMetricTypeName.ToString();
                                    dataRow[4] = pspMetricCounterData.Name.ToString();
                                    dataRow[5] = pspMetricCounterData.PspMetricObjectType.ToString();
                                    dataRow[6] = pspMetricCounterData.itemCount.ToString();
                                    dataRow[7] = pspMetricCounterData.baseLine.ToString();
                                    dataRow[8] = pspMetricCounterData.addedLine.ToString();
                                    dataRow[9] = pspMetricCounterData.modifyLine.ToString();
                                    dataRow[10] = pspMetricCounterData.deleteLine.ToString();
                                    dataTable.Rows.Add(dataRow);
                                }
                            }
                        }
                    }
                    dataTable.DefaultView.Sort = "FilePath asc";
                    foreach (DataRow dataRow2 in dataTable.Select())
                    {
                        this.objResult.CountResultPspSummary.AddCountResultPspSummaryRow(dataRow2[0].ToString(), dataRow2[1].ToString(), dataRow2[2].ToString(), dataRow2[3].ToString(), dataRow2[4].ToString(), dataRow2[5].ToString(), Convert.ToInt64(dataRow2[6]), Convert.ToInt64(dataRow2[7]), Convert.ToInt64(dataRow2[8]), Convert.ToInt64(dataRow2[9]), Convert.ToInt64(dataRow2[10]));
                    }
                }
            }
        }

        // Token: 0x060001DF RID: 479 RVA: 0x00015840 File Offset: 0x00014840
        private void InitDataSetPspDetails()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CounterItemID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("FilePath", typeof(string));
            dataTable.Columns.Add("TagType", typeof(string));
            dataTable.Columns.Add("TagName", typeof(string));
            dataTable.Columns.Add("ParentName", typeof(string));
            dataTable.Columns.Add("Status", typeof(string));
            dataTable.Columns.Add("Base", typeof(long));
            dataTable.Columns.Add("Added", typeof(long));
            dataTable.Columns.Add("Modified", typeof(long));
            dataTable.Columns.Add("Deleted", typeof(long));
            foreach (object obj in this.CISet)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount && counterItem.PspMetrics)
                {
                    dataTable.Rows.Clear();
                    foreach (LineCounter lineCounter in ((CodeCounter)counterItem.PspMetricHash["PspMetric"]).LineCounters)
                    {
                        foreach (object obj2 in lineCounter.PspMetricFileHash)
                        {
                            DictionaryEntry dictionaryEntry = (DictionaryEntry)obj2;
                            string text = dictionaryEntry.Key.ToString();
                            try
                            {
                                text = text.Substring(text.LastIndexOf("\\") + 1);
                                text = text.Substring(37);
                            }
                            catch
                            {
                                text = "";
                            }
                            foreach (object obj3 in ((PspMetricFileData)dictionaryEntry.Value).pspMetricCounterDataSet)
                            {
                                PspMetricCounterData pspMetricCounterData = (PspMetricCounterData)obj3;
                                DataRow dataRow = dataTable.NewRow();
                                dataRow[0] = counterItem.CounterItemID;
                                dataRow[1] = counterItem.Name;
                                dataRow[2] = "./" + text;
                                dataRow[3] = pspMetricCounterData.PspMetricTypeName.ToString();
                                dataRow[4] = pspMetricCounterData.Name.ToString();
                                dataRow[5] = pspMetricCounterData.parentString;
                                string value;
                                switch (pspMetricCounterData.PspExistType)
                                {
                                    case 0:
                                        value = "new";
                                        break;
                                    case 1:
                                        value = "";
                                        break;
                                    case 2:
                                        value = "";
                                        if (pspMetricCounterData.NewName != pspMetricCounterData.Name)
                                        {
                                            value = "name changed (" + pspMetricCounterData.NewName + ")";
                                        }
                                        break;
                                    case 3:
                                        value = "deleted";
                                        break;
                                    default:
                                        value = "";
                                        break;
                                }
                                dataRow[6] = value;
                                dataRow[7] = pspMetricCounterData.baseLine.ToString();
                                dataRow[8] = pspMetricCounterData.addedLine.ToString();
                                dataRow[9] = pspMetricCounterData.modifyLine.ToString();
                                dataRow[10] = pspMetricCounterData.deleteLine.ToString();
                                dataTable.Rows.Add(dataRow);
                            }
                        }
                    }
                    dataTable.DefaultView.Sort = "FilePath asc";
                    foreach (DataRow dataRow2 in dataTable.Select())
                    {
                        this.objResult.CountResultPspDetails.AddCountResultPspDetailsRow(dataRow2[0].ToString(), dataRow2[1].ToString(), dataRow2[2].ToString(), dataRow2[3].ToString(), dataRow2[4].ToString(), dataRow2[5].ToString(), dataRow2[6].ToString(), Convert.ToInt64(dataRow2[7]), Convert.ToInt64(dataRow2[8]), Convert.ToInt64(dataRow2[9]), Convert.ToInt64(dataRow2[10]));
                    }
                }
            }
        }

        // Token: 0x060001E0 RID: 480 RVA: 0x00015DE4 File Offset: 0x00014DE4
        private void InitListViewFileItem()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CounterItemID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("FilePath", typeof(string));
            dataTable.Columns.Add("Base", typeof(long));
            dataTable.Columns.Add("Added", typeof(long));
            dataTable.Columns.Add("Modified", typeof(long));
            dataTable.Columns.Add("Deleted", typeof(long));
            foreach (object obj in this.CISet)
            {
                CounterItem counterItem = (CounterItem)obj;
                dataTable.Clear();
                if (counterItem.ToBeCount)
                {
                    long num = 0L;
                    long num2 = 0L;
                    long num3 = 0L;
                    long num4 = 0L;
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        num += lineCounterData.Base;
                        num2 += lineCounterData.AddedLine;
                        num3 += lineCounterData.ModifiedLine;
                        num4 += lineCounterData.DeletedLine;
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = counterItem.CounterItemID;
                        dataRow[2] = lineCounterData.Name;
                        dataRow[3] = lineCounterData.Base;
                        dataRow[4] = lineCounterData.AddedLine;
                        dataRow[5] = lineCounterData.ModifiedLine;
                        dataRow[6] = lineCounterData.DeletedLine;
                        if (counterItem.Type == CIType.DATE_RANGE)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Date Range] [From Date :",
                                counterItem.StartDate.ToShortDateString(),
                                " - To Date :",
                                counterItem.EndDate.ToShortDateString(),
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST)
                        {
                            dataRow[1] = counterItem.Name + " [Latest] ";
                        }
                        else if (counterItem.Type == CIType.LABEL_CHANGESET)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.DIFF_PREVIOUS)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff/Previous] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST_SET)
                        {
                            dataRow[1] = counterItem.Name + " [Latest Set] [" + counterItem.BaseVersion + "]";
                        }
                        else if (counterItem.Type == CIType.ITEM_FOLDER)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff folder] [",
                                counterItem.ServerName,
                                "/",
                                counterItem.DiffItem,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST_WORKITEM)
                        {
                            dataRow[1] = counterItem.Name + " [ Latest WorkItem ][" + counterItem.BaseItem + "]";
                        }
                        else
                        {
                            dataRow[1] = counterItem.Name + " [ Not known Type ]";
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    dataTable.DefaultView.Sort = "FilePath asc";
                    foreach (DataRow dataRow2 in dataTable.Select())
                    {
                        this.objResult.CounterResultData.AddCounterResultDataRow(dataRow2[0].ToString(), dataRow2[1].ToString(), dataRow2[2].ToString(), Convert.ToInt64(dataRow2[3]), Convert.ToInt64(dataRow2[4]), Convert.ToInt64(dataRow2[5]), Convert.ToInt64(dataRow2[6]));
                    }
                }
            }
        }

        // Token: 0x060001E1 RID: 481 RVA: 0x000163F0 File Offset: 0x000153F0
        private void InitListViewFolder()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("CounterItemID", typeof(string));
            dataTable.Columns.Add("Name", typeof(string));
            dataTable.Columns.Add("Folder", typeof(string));
            dataTable.Columns.Add("Base", typeof(long));
            dataTable.Columns.Add("Added", typeof(long));
            dataTable.Columns.Add("Modified", typeof(long));
            dataTable.Columns.Add("Deleted", typeof(long));
            ArrayList arrayList = new ArrayList();
            Hashtable hashtable = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            Hashtable hashtable3 = new Hashtable();
            Hashtable hashtable4 = new Hashtable();
            arrayList.Clear();
            hashtable.Clear();
            hashtable2.Clear();
            hashtable3.Clear();
            hashtable4.Clear();
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                dataTable.Clear();
                if (counterItem.ToBeCount)
                {
                    ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        string text = lineCounterData.Name.Substring(0, lineCounterData.Name.LastIndexOf("/") + 1);
                        if (!arrayList.Contains(text))
                        {
                            arrayList.Add(text);
                            try
                            {
                                hashtable.Add(text, lineCounterData.Base);
                                hashtable2.Add(text, lineCounterData.AddedLine);
                                hashtable3.Add(text, lineCounterData.ModifiedLine);
                                hashtable4.Add(text, lineCounterData.DeletedLine);
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            hashtable[text] = (long)hashtable[text] + lineCounterData.Base;
                            hashtable2[text] = (long)hashtable2[text] + lineCounterData.AddedLine;
                            hashtable3[text] = (long)hashtable3[text] + lineCounterData.ModifiedLine;
                            hashtable4[text] = (long)hashtable4[text] + lineCounterData.DeletedLine;
                        }
                    }
                    arrayList.Sort();
                    for (int i = arrayList.Count - 1; i >= 0; i--)
                    {
                        for (int j = i - 1; j >= 0; j--)
                        {
                            if (arrayList[i].ToString().Contains(arrayList[j].ToString()))
                            {
                                hashtable[arrayList[j].ToString()] = (long)hashtable[arrayList[j].ToString()] + (long)hashtable[arrayList[i].ToString()];
                                hashtable2[arrayList[j].ToString()] = (long)hashtable2[arrayList[j].ToString()] + (long)hashtable2[arrayList[i].ToString()];
                                hashtable3[arrayList[j].ToString()] = (long)hashtable3[arrayList[j].ToString()] + (long)hashtable3[arrayList[i].ToString()];
                                hashtable4[arrayList[j].ToString()] = (long)hashtable4[arrayList[j].ToString()] + (long)hashtable4[arrayList[i].ToString()];
                                break;
                            }
                        }
                    }
                    ListViewItem[] array = new ListViewItem[arrayList.Count];
                    foreach (object obj3 in arrayList)
                    {
                        long num = (long)hashtable2[obj3] + (long)hashtable3[obj3];
                        ListViewItem listViewItem = new ListViewItem(new string[]
                        {
                            obj3.ToString(),
                            hashtable[obj3].ToString(),
                            hashtable2[obj3].ToString(),
                            hashtable3[obj3].ToString(),
                            hashtable4[obj3].ToString(),
                            num.ToString()
                        });
                        listViewItem.Group = listViewGroup;
                        DataRow dataRow = dataTable.NewRow();
                        dataRow[0] = counterItem.CounterItemID;
                        dataRow[2] = obj3.ToString();
                        dataRow[3] = hashtable[obj3].ToString();
                        dataRow[4] = hashtable2[obj3].ToString();
                        dataRow[5] = hashtable3[obj3].ToString();
                        dataRow[6] = hashtable4[obj3].ToString();
                        if (counterItem.Type == CIType.DATE_RANGE)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Date Range] [From Date :",
                                counterItem.StartDate.ToShortDateString(),
                                " - To Date :",
                                counterItem.EndDate.ToShortDateString(),
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST)
                        {
                            dataRow[1] = counterItem.Name + " [Latest] ";
                        }
                        else if (counterItem.Type == CIType.LABEL_CHANGESET)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.DIFF_PREVIOUS)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff/Previous] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST_SET)
                        {
                            dataRow[1] = counterItem.Name + " [Latest Set] [" + counterItem.BaseVersion + "]";
                        }
                        else if (counterItem.Type == CIType.ITEM_FOLDER)
                        {
                            dataRow[1] = string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff folder] [",
                                counterItem.ServerName,
                                "/",
                                counterItem.DiffItem,
                                "]"
                            });
                        }
                        else if (counterItem.Type == CIType.LATEST_WORKITEM)
                        {
                            dataRow[1] = counterItem.Name + " [Latest WorkItem] [" + counterItem.BaseItem + "]";
                        }
                        else
                        {
                            dataRow[1] = counterItem.Name + " [Not known] ";
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    listViewGroup.Header = counterItem.Name;
                    arrayList.Clear();
                    hashtable.Clear();
                    hashtable2.Clear();
                    hashtable3.Clear();
                    hashtable4.Clear();
                    dataTable.DefaultView.Sort = "Folder asc";
                    foreach (DataRow dataRow2 in dataTable.Select())
                    {
                        this.objResult.CounterResultFolderData.AddCounterResultFolderDataRow(dataRow2[0].ToString(), dataRow2[1].ToString(), dataRow2[2].ToString(), Convert.ToInt64(dataRow2[3]), Convert.ToInt64(dataRow2[4]), Convert.ToInt64(dataRow2[5]), Convert.ToInt64(dataRow2[6]));
                    }
                }
            }
        }

        // Token: 0x060001E2 RID: 482 RVA: 0x00016E8C File Offset: 0x00015E8C
        private void ShowListViewFolder()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CounterResultFolderData.Rows.Count];
            for (int i = 0; i < this.objResult.CounterResultFolderData.Rows.Count; i++)
            {
                if (a != this.objResult.CounterResultFolderData.Rows[i][0].ToString())
                {
                    a = this.objResult.CounterResultFolderData.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CounterResultFolderData.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewFolders.Groups.Add(group);
                }
                int num = Convert.ToInt32(this.objResult.CounterResultFolderData.Rows[i][4]) + Convert.ToInt32(this.objResult.CounterResultFolderData.Rows[i][5]);
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CounterResultFolderData.Rows[i][2].ToString(),
                    this.objResult.CounterResultFolderData.Rows[i][3].ToString(),
                    this.objResult.CounterResultFolderData.Rows[i][4].ToString(),
                    this.objResult.CounterResultFolderData.Rows[i][5].ToString(),
                    this.objResult.CounterResultFolderData.Rows[i][6].ToString(),
                    num.ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewFolders.Items.AddRange(array);
        }

        // Token: 0x060001E3 RID: 483 RVA: 0x000170C4 File Offset: 0x000160C4
        private void InitListViewExclude()
        {
            ArrayList arrayList = new ArrayList();
            Hashtable hashtable = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            Hashtable hashtable3 = new Hashtable();
            Hashtable hashtable4 = new Hashtable();
            this.listViewExcluded.Items.Clear();
            arrayList.Clear();
            hashtable.Clear();
            hashtable2.Clear();
            hashtable3.Clear();
            hashtable4.Clear();
            int num = 0;
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    ListViewGroup group = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
                    LineCounter[] lineCounters = this.counterArray[num].LineCounters;
                    foreach (LineCounter lineCounter in lineCounters)
                    {
                        for (int j = 0; j < lineCounter.codeAreas.Length; j++)
                        {
                            if (!lineCounter.codeAreas[j].CountsAsCode && lineCounter.counterData[j].TotalCount > 0)
                            {
                                ListViewItem listViewItem = new ListViewItem(new string[]
                                {
                                    lineCounter.counterData[j].Name.ToString(),
                                    lineCounter.counterData[j].TotalCount.ToString(),
                                    "",
                                    "",
                                    "",
                                    ""
                                });
                                listViewItem.Group = group;
                                if (counterItem.Type == CIType.DATE_RANGE)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, string.Concat(new string[]
                                    {
                                        counterItem.Name,
                                        " [Date Range] [From Date :",
                                        counterItem.StartDate.ToShortDateString(),
                                        " - To Date :",
                                        counterItem.EndDate.ToShortDateString(),
                                        "]"
                                    }), lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.LATEST)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, counterItem.Name + " [Latest] ", lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.LABEL_CHANGESET)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, string.Concat(new string[]
                                    {
                                        counterItem.Name,
                                        " [Label/Changeset] [",
                                        counterItem.BaseVersion,
                                        "/",
                                        counterItem.DiffVersion,
                                        "]"
                                    }), lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, string.Concat(new string[]
                                    {
                                        counterItem.Name,
                                        " [Diff Label/Changeset] [",
                                        counterItem.BaseVersion,
                                        "/",
                                        counterItem.DiffVersion,
                                        "]"
                                    }), lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.DIFF_PREVIOUS)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, string.Concat(new string[]
                                    {
                                        counterItem.Name,
                                        " [Diff/Previous] [",
                                        counterItem.BaseVersion,
                                        "/",
                                        counterItem.DiffVersion,
                                        "]"
                                    }), lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.LATEST_SET)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, counterItem.Name + " [Latest Set] [" + counterItem.BaseVersion + "]", lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.ITEM_FOLDER)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, string.Concat(new string[]
                                    {
                                        counterItem.Name,
                                        " [Diff folder] [",
                                        counterItem.ServerName,
                                        "/",
                                        counterItem.DiffItem,
                                        "]"
                                    }), lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                                else if (counterItem.Type == CIType.LATEST_WORKITEM)
                                {
                                    this.objResult.CounterResultExcludeData.AddCounterResultExcludeDataRow(counterItem.CounterItemID, counterItem.Name + " [Latest WorkItem] [" + counterItem.BaseItem + "]", lineCounter.counterData[j].Name.ToString(), long.Parse(lineCounter.counterData[j].TotalCount.ToString()));
                                }
                            }
                        }
                    }
                    num++;
                }
            }
        }

        // Token: 0x060001E4 RID: 484 RVA: 0x000177C4 File Offset: 0x000167C4
        private void ShowListViewExclude()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CounterResultExcludeData.Rows.Count];
            for (int i = 0; i < this.objResult.CounterResultExcludeData.Rows.Count; i++)
            {
                if (a != this.objResult.CounterResultExcludeData.Rows[i][0].ToString())
                {
                    a = this.objResult.CounterResultExcludeData.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CounterResultExcludeData.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewExcluded.Groups.Add(group);
                }
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CounterResultExcludeData.Rows[i][2].ToString(),
                    this.objResult.CounterResultExcludeData.Rows[i][3].ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewExcluded.Items.AddRange(array);
        }

        // Token: 0x060001E5 RID: 485 RVA: 0x00017938 File Offset: 0x00016938
        private void InitListViewLanguage()
        {
            this.listViewLanguage.Items.Clear();
            ArrayList arrayList = new ArrayList();
            Hashtable hashtable = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            Hashtable hashtable3 = new Hashtable();
            Hashtable hashtable4 = new Hashtable();
            arrayList.Clear();
            hashtable.Clear();
            hashtable2.Clear();
            hashtable3.Clear();
            hashtable4.Clear();
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        string text = lineCounterData.Language.ToString();
                        if (!arrayList.Contains(text))
                        {
                            arrayList.Add(text);
                            try
                            {
                                hashtable.Add(text, lineCounterData.Base);
                                hashtable2.Add(text, lineCounterData.AddedLine);
                                hashtable3.Add(text, lineCounterData.ModifiedLine);
                                hashtable4.Add(text, lineCounterData.DeletedLine);
                            }
                            catch
                            {
                            }
                        }
                        else
                        {
                            hashtable[text] = (long)hashtable[text] + lineCounterData.Base;
                            hashtable2[text] = (long)hashtable2[text] + lineCounterData.AddedLine;
                            hashtable3[text] = (long)hashtable3[text] + lineCounterData.ModifiedLine;
                            hashtable4[text] = (long)hashtable4[text] + lineCounterData.DeletedLine;
                        }
                    }
                    arrayList.Sort();
                    foreach (object obj3 in arrayList)
                    {
                        long num = (long)hashtable2[obj3] + (long)hashtable3[obj3];
                        if (counterItem.Type == CIType.DATE_RANGE)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Date Range] [From Date :",
                                counterItem.StartDate.ToShortDateString(),
                                " - To Date :",
                                counterItem.EndDate.ToShortDateString(),
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.LATEST)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, counterItem.Name + " [Latest] ", obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.LABEL_CHANGESET)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff Label/Changeset] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.DIFF_PREVIOUS)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff/Previous] [",
                                counterItem.BaseVersion,
                                "/",
                                counterItem.DiffVersion,
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.LATEST_SET)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, counterItem.Name + " [Latest Set] [" + counterItem.BaseVersion + "]", obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.ITEM_FOLDER)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Diff folder] [",
                                counterItem.ServerName,
                                "/",
                                counterItem.DiffItem,
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        else if (counterItem.Type == CIType.LATEST_WORKITEM)
                        {
                            this.objResult.CounterResultLanguageData.AddCounterResultLanguageDataRow(counterItem.CounterItemID, string.Concat(new string[]
                            {
                                counterItem.Name,
                                " [Work Item] [",
                                counterItem.ServerName,
                                "/",
                                counterItem.DiffItem,
                                "]"
                            }), obj3.ToString(), long.Parse(hashtable[obj3].ToString()), long.Parse(hashtable2[obj3].ToString()), long.Parse(hashtable3[obj3].ToString()), long.Parse(hashtable4[obj3].ToString()));
                        }
                        listViewGroup.Header = counterItem.Name;
                    }
                    arrayList.Clear();
                    hashtable.Clear();
                    hashtable2.Clear();
                    hashtable3.Clear();
                    hashtable4.Clear();
                }
            }
            this.listViewLanguage.Sort();
        }

        // Token: 0x060001E6 RID: 486 RVA: 0x000182D8 File Offset: 0x000172D8
        private void ShowListViewLanguage()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CounterResultLanguageData.Rows.Count];
            for (int i = 0; i < this.objResult.CounterResultLanguageData.Rows.Count; i++)
            {
                if (a != this.objResult.CounterResultLanguageData.Rows[i][0].ToString())
                {
                    a = this.objResult.CounterResultLanguageData.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CounterResultLanguageData.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewLanguage.Groups.Add(group);
                }
                int num = Convert.ToInt32(this.objResult.CounterResultLanguageData.Rows[i][4]) + Convert.ToInt32(this.objResult.CounterResultLanguageData.Rows[i][5]);
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CounterResultLanguageData.Rows[i][2].ToString(),
                    this.objResult.CounterResultLanguageData.Rows[i][3].ToString(),
                    this.objResult.CounterResultLanguageData.Rows[i][4].ToString(),
                    this.objResult.CounterResultLanguageData.Rows[i][5].ToString(),
                    this.objResult.CounterResultLanguageData.Rows[i][6].ToString(),
                    num.ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewLanguage.Items.AddRange(array);
        }

        // Token: 0x060001E7 RID: 487 RVA: 0x00018510 File Offset: 0x00017510
        private void InitListViewMReport()
        {
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    long num = 0L;
                    long num2 = 0L;
                    long num3 = 0L;
                    long num4 = 0L;
                    int num5 = 0;
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        num += lineCounterData.Base;
                        num2 += lineCounterData.AddedLine;
                        num3 += lineCounterData.ModifiedLine;
                        num4 += lineCounterData.DeletedLine;
                        if (lineCounterData.AddedLine + lineCounterData.ModifiedLine + lineCounterData.DeletedLine > 0L)
                        {
                            num5++;
                        }
                    }
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Counter task name", "", counterItem.Name);
                    string data = string.Empty;
                    if (counterItem.Type == CIType.DATE_RANGE)
                    {
                        data = string.Concat(new string[]
                        {
                            " [Date Range] [From Date :",
                            counterItem.StartDate.ToShortDateString(),
                            " - To Date :",
                            counterItem.EndDate.ToShortDateString(),
                            "]"
                        });
                    }
                    else if (counterItem.Type == CIType.LATEST)
                    {
                        data = " [Latest] ";
                    }
                    else if (counterItem.Type == CIType.LABEL_CHANGESET)
                    {
                        data = string.Concat(new string[]
                        {
                            " [Label/Changeset] [",
                            counterItem.BaseVersion,
                            "/",
                            counterItem.DiffVersion,
                            "] "
                        });
                    }
                    else if (counterItem.Type == CIType.BASEDTO_LABEL_CHANGESET)
                    {
                        data = string.Concat(new string[]
                        {
                            " [Diff Label/Changeset] [",
                            counterItem.BaseVersion,
                            "/",
                            counterItem.DiffVersion,
                            "] "
                        });
                    }
                    else if (counterItem.Type == CIType.DIFF_PREVIOUS)
                    {
                        data = string.Concat(new string[]
                        {
                            " [Diff Previous Version] [",
                            counterItem.BaseVersion,
                            "/",
                            counterItem.DiffVersion,
                            "] "
                        });
                    }
                    else if (counterItem.Type == CIType.LATEST_SET)
                    {
                        data = " [Latest Set] [" + counterItem.BaseVersion + "] ";
                    }
                    else if (counterItem.Type == CIType.LATEST_WORKITEM)
                    {
                        data = " [Latest WorkItem] [" + counterItem.BaseItem + "] ";
                    }
                    else if (counterItem.Type == CIType.ITEM_FOLDER)
                    {
                        data = string.Concat(new string[]
                        {
                            " [Diff folder] [",
                            counterItem.ServerName,
                            "/",
                            counterItem.DiffItem,
                            "]"
                        });
                    }
                    else
                    {
                        data = " [Not known]";
                    }
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Count Type", "", data);
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Counting Standard", "", AppConfigurationManager.CurrentCountStandard.SourceLocation + " ( " + AppConfigurationManager.CurrentCountStandard.Version + " ) ");
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Base", "LOC at the start", num.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Added", "Added LOC", num2.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Modified", "LOC Modified", num3.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Deleted", "LOC Deleted", num4.ToString());
                    long num6 = num + num2 - num4;
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Total LOC", "Base + Added - Deleted LOC", Convert.ToString(num6));
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Churned LOC", "Added + Modified LOC", Convert.ToString(num2 + num3));
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Line Worked On", "Added + Modified + Deleted LOC", Convert.ToString(num2 + num3 + num4));
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "", "", "");
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "File count", "Number of files in the Counter Task", counterItem.CounterDataSet.Count.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Weeks of Churn", "Number of weeks during which the code changes occurred", counterItem.WeeksofChurn.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Churn count", "Number of checkins for the files churned", counterItem.Churncount.ToString());
                    this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Files Churned", "Number of files that have either Added or Modified or Deleted LOC > 0", num5.ToString());
                    if (counterItem.MReport)
                    {
                        this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "", "", "");
                        MReport mreport = new MReport();
                        if (num6 != 0L)
                        {
                            mreport.M1 = Convert.ToDouble(num2 + num3) / Convert.ToDouble(num6);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M1", "Churned LOC / Total LOC", Convert.ToString(mreport.M1));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M1", "Churned LOC / Total LOC", "--");
                        }
                        if (num6 != 0L)
                        {
                            mreport.M2 = Convert.ToDouble(num4) / Convert.ToDouble(num6);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M2", "Deleted LOC / Total LOC", Convert.ToString(mreport.M2));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M2", "Deleted LOC / Total LOC", "--");
                        }
                        if (counterItem.CounterDataSet.Count != 0)
                        {
                            mreport.M3 = Convert.ToDouble(num5) / Convert.ToDouble(counterItem.CounterDataSet.Count);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M3", "Files Churned / File Count", Convert.ToString(mreport.M3));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M3", "Files Churned / File Count", "--");
                        }
                        if (num5 != 0)
                        {
                            mreport.M4 = Convert.ToDouble(counterItem.Churncount) / Convert.ToDouble(num5);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M4", "Churn Count / Files Churned", Convert.ToString(mreport.M4));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M4", "Churn Count / Files Churned", "--");
                        }
                        if (counterItem.CounterDataSet.Count != 0)
                        {
                            mreport.M5 = Convert.ToDouble(counterItem.WeeksofChurn) / Convert.ToDouble(counterItem.CounterDataSet.Count);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M5", "Weeks of Churn / File Count", Convert.ToString(mreport.M5));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M5", "Weeks of Churn / File Count", "--");
                        }
                        if (counterItem.WeeksofChurn != 0.0)
                        {
                            mreport.M6 = Convert.ToDouble(num2 + num3 + num4) / Convert.ToDouble(counterItem.WeeksofChurn);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M6", "Lines Worked On / Weeks of Churn", Convert.ToString(mreport.M6));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M6", "Lines Worked On / Weeks of Churn", "--");
                        }
                        if (num4 != 0L)
                        {
                            mreport.M7 = Convert.ToDouble(num2 + num3) / Convert.ToDouble(num4);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M7", "Churned LOC / Deleted LOC", Convert.ToString(mreport.M7));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M7", "Churned LOC / Deleted LOC", "--");
                        }
                        if (counterItem.Churncount != 0.0)
                        {
                            mreport.M8 = Convert.ToDouble(num2 + num3 + num4) / Convert.ToDouble(counterItem.Churncount);
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M8", "Lines Worked On / Churn Count", Convert.ToString(mreport.M8));
                        }
                        else
                        {
                            this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "M8", "Lines Worked On / Churn Count", "--");
                        }
                        this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "", "", "");
                        this.objResult.CounterResultMReportData.AddCounterResultMReportDataRow(counterItem.CounterItemID, counterItem.Name, "Estimated Defect Density", "Applying multiple regression for the relative measures (M1 - M8) above", Convert.ToString(mreport.DefectDensity));
                    }
                }
            }
        }

        // Token: 0x060001E8 RID: 488 RVA: 0x000190F8 File Offset: 0x000180F8
        private void ShowListViewMReort()
        {
            ListViewGroup group = new ListViewGroup();
            string a = string.Empty;
            ListViewItem[] array = new ListViewItem[this.objResult.CounterResultMReportData.Rows.Count];
            for (int i = 0; i < this.objResult.CounterResultMReportData.Rows.Count; i++)
            {
                if (a != this.objResult.CounterResultMReportData.Rows[i][0].ToString())
                {
                    a = this.objResult.CounterResultMReportData.Rows[i][0].ToString();
                    group = new ListViewGroup(this.objResult.CounterResultMReportData.Rows[i][1].ToString(), HorizontalAlignment.Left);
                    this.listViewMReport.Groups.Add(group);
                }
                array[i] = new ListViewItem(new string[]
                {
                    this.objResult.CounterResultMReportData.Rows[i][2].ToString(),
                    this.objResult.CounterResultMReportData.Rows[i][3].ToString(),
                    this.objResult.CounterResultMReportData.Rows[i][4].ToString()
                })
                {
                    Group = group
                };
            }
            this.listViewMReport.Items.AddRange(array);
        }

        // Token: 0x060001E9 RID: 489 RVA: 0x00019294 File Offset: 0x00018294
        private void insertResult()
        {
            ArrayList arrayList = new ArrayList();
            Hashtable hashtable = new Hashtable();
            Hashtable hashtable2 = new Hashtable();
            arrayList.Clear();
            hashtable.Clear();
            hashtable2.Clear();
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    ListViewGroup listViewGroup = new ListViewGroup(counterItem.CounterItemID, HorizontalAlignment.Left);
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        string text = lineCounterData.Language.ToString();
                        if (!arrayList.Contains(text))
                        {
                            arrayList.Add(text);
                            try
                            {
                                hashtable.Add(text, lineCounterData.AddedLine);
                                hashtable2.Add(text, lineCounterData.ModifiedLine);
                            }
                            catch (Exception ex)
                            {
                                string text2 = ex.ToString();
                            }
                        }
                        else
                        {
                            hashtable[text] = (long)hashtable[text] + lineCounterData.AddedLine;
                            hashtable2[text] = (long)hashtable2[text] + lineCounterData.ModifiedLine;
                        }
                    }
                    arrayList.Sort();
                    foreach (object obj3 in arrayList)
                    {
                        long num = (long)hashtable[obj3] + (long)hashtable2[obj3];
                        ListViewItem listViewItem = new ListViewItem(new string[]
                        {
                            obj3.ToString(),
                            num.ToString()
                        });
                    }
                    long csharpNum = 0L;
                    long cplusNum = 0L;
                    long sqlNum = 0L;
                    long vbnetNum = 0L;
                    long webFilesNum = 0L;
                    long xmlFilesNum = 0L;
                    foreach (object obj4 in this.listViewLanguage.Items)
                    {
                        ListViewItem listViewItem2 = (ListViewItem)obj4;
                        if (listViewItem2.SubItems[0].Text == "C#")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                csharpNum = Convert.ToInt64(text3);
                            }
                        }
                        if (listViewItem2.SubItems[0].Text == "C++")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                cplusNum = Convert.ToInt64(text3);
                            }
                        }
                        if (listViewItem2.SubItems[0].Text == "SQL")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                sqlNum = Convert.ToInt64(text3);
                            }
                        }
                        if (listViewItem2.SubItems[0].Text == "VB.NET")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                vbnetNum = Convert.ToInt64(text3);
                            }
                        }
                        if (listViewItem2.SubItems[0].Text == "Web files")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                webFilesNum = Convert.ToInt64(text3);
                            }
                        }
                        if (listViewItem2.SubItems[0].Text == "Xml files")
                        {
                            string text3 = listViewItem2.SubItems[1].Text;
                            if (text3 != "")
                            {
                                xmlFilesNum = Convert.ToInt64(text3);
                            }
                        }
                    }
                    ConfigManager configManager = new ConfigManager();
                    if (configManager.CheckTaskIn(counterItem.CounterItemID))
                    {
                        configManager.UpdateResult(counterItem, csharpNum, cplusNum, sqlNum, vbnetNum, webFilesNum, xmlFilesNum);
                    }
                    else
                    {
                        configManager.InsertResult(counterItem, csharpNum, cplusNum, sqlNum, vbnetNum, webFilesNum, xmlFilesNum);
                    }
                    arrayList.Clear();
                    hashtable.Clear();
                    hashtable2.Clear();
                }
            }
            this.listViewLanguage.Sort();
        }

        // Token: 0x060001EA RID: 490 RVA: 0x00019858 File Offset: 0x00018858
        private void OnShow(object sender, EventArgs e)
        {
            this.objResult = new CounterResult();
            bool enabled = false;
            foreach (object obj in this.CISet.FilteredItems)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount && counterItem.PspMetrics)
                {
                    enabled = true;
                    break;
                }
            }
            this.btnPspReport.Enabled = enabled;
            if (AppConfigurationManager.CurrentCountStandard != null)
            {
                this.lblStandardVersion.Text = AppConfigurationManager.CurrentCountStandard.Version;
                this.lblStandardFrom.Text = AppConfigurationManager.CurrentCountStandard.SourceLocation;
            }
            this.InitListViewFileItem();
            this.InitListViewFolder();
            this.InitListViewExclude();
            this.InitListViewLanguage();
            this.InitListViewMReport();
            this.InitDataSetPspSummary();
            this.InitDataSetPspDetails();
            this.ShowListViewFileItem();
            this.ShowListViewPspMetrics();
            this.ShowListViewFolder();
            this.ShowListViewLanguage();
            this.ShowListViewExclude();
            this.ShowListViewMReort();
        }

        // Token: 0x060001EB RID: 491 RVA: 0x0001998C File Offset: 0x0001898C
        private void test(ListView lv)
        {
            ListViewGroup group = new ListViewGroup("1111", HorizontalAlignment.Left);
            this.lvWItems.Groups.Add(group);
            ListViewItem[] array = new ListViewItem[100000];
            for (int i = 0; i < 100000; i++)
            {
                array[i] = new ListViewItem(new string[]
                {
                    "dataname",
                    "data.Base.ToString()",
                    "data.AddedLine.ToString()",
                    "data.ModifiedLine.ToString()",
                    "data.DeletedLine.ToString()",
                    "(data.AddedLine + data.ModifiedLine).ToString()"
                })
                {
                    Group = group
                };
            }
            lv.Items.AddRange(array);
        }

        // Token: 0x060001EC RID: 492 RVA: 0x00019A3C File Offset: 0x00018A3C
        private void btnSave_Click(object sender, EventArgs e)
        {
            CounterCountDetailSet counterCountDetailSet = new CounterCountDetailSet();
            foreach (object obj in this.CISet)
            {
                CounterItem counterItem = (CounterItem)obj;
                if (counterItem.ToBeCount)
                {
                    Hashtable hashtable = new Hashtable();
                    foreach (object obj2 in counterItem.CounterDataSet)
                    {
                        LineCounterData lineCounterData = (LineCounterData)obj2;
                        CounterCountDetail counterCountDetail;
                        if (hashtable.ContainsKey(lineCounterData.Language))
                        {
                            counterCountDetail = (CounterCountDetail)hashtable[lineCounterData.Language];
                        }
                        else
                        {
                            counterCountDetail = new CounterCountDetail();
                            counterCountDetail.CounterItemID = counterItem.CounterItemID;
                            counterCountDetail.Language = lineCounterData.Language;
                            counterCountDetail.Base = 0L;
                            counterCountDetail.Added = 0L;
                            counterCountDetail.Modified = 0L;
                            counterCountDetail.Deleted = 0L;
                            hashtable[lineCounterData.Language] = counterCountDetail;
                        }
                        counterCountDetail.Base += lineCounterData.Base;
                        counterCountDetail.Added += lineCounterData.AddedLine;
                        counterCountDetail.Modified += lineCounterData.ModifiedLine;
                        counterCountDetail.Deleted += lineCounterData.DeletedLine;
                    }
                    counterCountDetailSet.Add(hashtable.Values);
                }
            }
            ConfigManager configManager = new ConfigManager();
            if (configManager.SaveCounterCountDetail(counterCountDetailSet, ExecutionMode.StandAlone))
            {
                foreach (object obj3 in this.CISet)
                {
                    CounterItem counterItem = (CounterItem)obj3;
                    if (counterItem.ToBeCount)
                    {
                        counterItem.ToBeCount = false;
                    }
                }
            }
            base.Close();
        }

        // Token: 0x060001ED RID: 493 RVA: 0x00019CC8 File Offset: 0x00018CC8
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        // Token: 0x060001EE RID: 494 RVA: 0x00019CD4 File Offset: 0x00018CD4
        private void btnViewReport_Click(object sender, EventArgs e)
        {
            new frmReportViewer
            {
                WindowState = FormWindowState.Maximized,
                ReportType = "Counter Result",
                DataSource = this.objResult
            }.ShowDialog();
        }

        // Token: 0x060001EF RID: 495 RVA: 0x00019D10 File Offset: 0x00018D10
        private void btnPspReport_Click(object sender, EventArgs e)
        {
            new frmReportViewer
            {
                WindowState = FormWindowState.Maximized,
                ReportType = "PSP Count Result",
                DataSource = this.objResult
            }.ShowDialog();
        }

        // Token: 0x04000173 RID: 371
        private CounterItemSet CISet;

        // Token: 0x04000174 RID: 372
        private CounterResult objResult;

        // Token: 0x04000175 RID: 373
        public CodeCounter[] counterArray;
    }
}
