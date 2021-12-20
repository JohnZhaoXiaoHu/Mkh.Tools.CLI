﻿using System.Text;

namespace Mkh.Tools.CLI.Templates.Default.src.Web;

public partial class Csproj : ITemplateHandler
{
    private GenerateModel _model;

    public void Save(GenerateModel model)
    {
        _model = model;

        var dir = Path.Combine(_model.CodeDir, "src/Web");
        if (!Directory.Exists(dir))
            Directory.CreateDirectory(dir);

        var content = TransformText();
        var filePath = Path.Combine(dir, "Web.csproj");
        File.WriteAllText(filePath, content, Encoding.UTF8);
    }
}