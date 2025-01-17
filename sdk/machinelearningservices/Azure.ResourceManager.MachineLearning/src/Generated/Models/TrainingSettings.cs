// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Training related configuration. </summary>
    public partial class TrainingSettings
    {
        /// <summary> Initializes a new instance of TrainingSettings. </summary>
        public TrainingSettings()
        {
        }

        /// <summary> Initializes a new instance of TrainingSettings. </summary>
        /// <param name="enableDnnTraining"> Enable recommendation of DNN models. </param>
        /// <param name="enableModelExplainability"> Flag to turn on explainability on best model. </param>
        /// <param name="enableOnnxCompatibleModels"> Flag for enabling onnx compatible models. </param>
        /// <param name="enableStackEnsemble"> Enable stack ensemble run. </param>
        /// <param name="enableVoteEnsemble"> Enable voting ensemble run. </param>
        /// <param name="ensembleModelDownloadTimeout">
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </param>
        /// <param name="stackEnsembleSettings"> Stack ensemble settings for stack ensemble run. </param>
        internal TrainingSettings(bool? enableDnnTraining, bool? enableModelExplainability, bool? enableOnnxCompatibleModels, bool? enableStackEnsemble, bool? enableVoteEnsemble, TimeSpan? ensembleModelDownloadTimeout, StackEnsembleSettings stackEnsembleSettings)
        {
            EnableDnnTraining = enableDnnTraining;
            EnableModelExplainability = enableModelExplainability;
            EnableOnnxCompatibleModels = enableOnnxCompatibleModels;
            EnableStackEnsemble = enableStackEnsemble;
            EnableVoteEnsemble = enableVoteEnsemble;
            EnsembleModelDownloadTimeout = ensembleModelDownloadTimeout;
            StackEnsembleSettings = stackEnsembleSettings;
        }

        /// <summary> Enable recommendation of DNN models. </summary>
        public bool? EnableDnnTraining { get; set; }
        /// <summary> Flag to turn on explainability on best model. </summary>
        public bool? EnableModelExplainability { get; set; }
        /// <summary> Flag for enabling onnx compatible models. </summary>
        public bool? EnableOnnxCompatibleModels { get; set; }
        /// <summary> Enable stack ensemble run. </summary>
        public bool? EnableStackEnsemble { get; set; }
        /// <summary> Enable voting ensemble run. </summary>
        public bool? EnableVoteEnsemble { get; set; }
        /// <summary>
        /// During VotingEnsemble and StackEnsemble model generation, multiple fitted models from the previous child runs are downloaded.
        /// Configure this parameter with a higher value than 300 secs, if more time is needed.
        /// </summary>
        public TimeSpan? EnsembleModelDownloadTimeout { get; set; }
        /// <summary> Stack ensemble settings for stack ensemble run. </summary>
        public StackEnsembleSettings StackEnsembleSettings { get; set; }
    }
}
