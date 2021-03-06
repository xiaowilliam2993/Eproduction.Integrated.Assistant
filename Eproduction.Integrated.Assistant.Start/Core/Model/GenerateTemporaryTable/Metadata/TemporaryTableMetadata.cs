﻿using System;

namespace Eproduction.Integrated.Assistant.Start.Core.Model.Metadata {
    
    public class TemporaryTableMetadata : IDisposable {

        public void Dispose() {
            GC.SuppressFinalize(this);
        }

        public TemporaryTableMetadata(GenerateTempoarayTableContext context)
            : base() {
            TransformSchemaObject = new TransformMetadata(context);
        }
        
        public TransformMetadata TransformSchemaObject { get; set; }

    }
}