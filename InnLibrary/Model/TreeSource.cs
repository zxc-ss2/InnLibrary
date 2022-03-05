using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnLibrary.Model
{
    public class TreeSource
    {
        private static Core db = new Core();
        private static List<RegionCodes> treeTable;


        public static List<Node> FillTreeNodeList(int parentID)
        {
            Node node;
            treeTable = db.context.RegionCodes.ToList();
            List<Node> resultTreeNodeList = new List<Node>();
            foreach (var item in treeTable
                             .Where(x => x.ParentID == parentID)
                             .OrderBy(x => x.Code)
                             .ToList())
            {
                node = new Node()
                {
                    ID = item.ID,
                    Code = item.Code,
                    Description = item.Description,
                    ParantID = item.ParentID ?? 0,
                    Nodes = FillTreeNodeList(item.ID)
                };
                resultTreeNodeList.Add(node);

            }
            return resultTreeNodeList;
        }

    }
}
   