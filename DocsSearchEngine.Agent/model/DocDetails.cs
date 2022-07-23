using Azure.Search.Documents.Indexes;
using System;
using System.Collections.Generic;
using System.Text;

namespace DocsSearchEngine.Agent.model
{
    public class DocDetails
    {
        [SearchableField(IsFilterable = true)]
        public string content { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_content_type { get; set; }
        [SearchableField(IsFilterable = true)]
        public int metadata_storage_size { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_last_modified { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_content_md5 { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_name { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_path { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_storage_file_extension { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_content_type { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_author { get; set; }
        [SearchableField(IsFilterable = true)]
        public string metadata_creation_date { get; set; }
        [SearchableField(IsFilterable = true)]
        public string[] people { get; set; }
        [SearchableField(IsFilterable = true)]
        public string[] organizations { get; set; }
        [SearchableField(IsFilterable = true)]
        public string[] locations { get; set; }
        [SearchableField(IsFilterable = true)]
        public string[] keyphrases { get; set; }
        [SearchableField(IsFilterable = true)]
        public string language { get; set; }
        [SearchableField(IsFilterable = true)]
        public string translated_text { get; set; }
        [SearchableField(IsFilterable = true)]
        public string masked_text { get; set; }
    }
}
