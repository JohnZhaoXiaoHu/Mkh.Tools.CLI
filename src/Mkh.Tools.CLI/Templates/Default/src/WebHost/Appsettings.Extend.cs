﻿using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.WebHost;

public partial class Appsettings : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(model.CodeDir, "src/WebHost");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "appsettings.json");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}