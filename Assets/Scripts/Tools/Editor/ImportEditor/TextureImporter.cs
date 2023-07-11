using UnityEditor;

public class TexturePostProcessor : AssetPostprocessor
{
    private void OnPreprocessTexture()
    {
        TextureImporter textureImporter = assetImporter as TextureImporter;
        textureImporter.textureType = TextureImporterType.Sprite;
    }
}
