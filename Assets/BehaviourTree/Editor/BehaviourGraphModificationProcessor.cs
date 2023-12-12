using System.IO;
using MbsCore.BehaviourTree.Runtime;
using UnityEditor;

namespace MbsCore.BehaviourTree.Editor
{
    public class BehaviourGraphModificationProcessor : AssetModificationProcessor
    {
        private static AssetMoveResult OnWillMoveAsset(string sourcePath, string destinationPath)
        {
            if (!(AssetDatabase.LoadMainAssetAtPath(sourcePath) is BehaviourGraphConfig graphConfig))
            {
                return AssetMoveResult.DidNotMove;
            }

            string sourceDirectory = Path.GetDirectoryName(sourcePath);
            string destinationDirectory = Path.GetDirectoryName(destinationPath);

            if (sourceDirectory != destinationDirectory)
            {
                return AssetMoveResult.DidNotMove;
            }

            string fileName = Path.GetFileNameWithoutExtension(destinationPath);
            graphConfig.name = fileName;
            return AssetMoveResult.DidNotMove;
        }
    }
}