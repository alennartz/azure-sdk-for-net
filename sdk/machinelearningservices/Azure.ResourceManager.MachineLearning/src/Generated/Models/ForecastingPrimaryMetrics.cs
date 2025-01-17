// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Primary metrics for Forecasting task. </summary>
    public readonly partial struct ForecastingPrimaryMetrics : IEquatable<ForecastingPrimaryMetrics>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ForecastingPrimaryMetrics"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ForecastingPrimaryMetrics(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SpearmanCorrelationValue = "SpearmanCorrelation";
        private const string NormalizedRootMeanSquaredErrorValue = "NormalizedRootMeanSquaredError";
        private const string R2ScoreValue = "R2Score";
        private const string NormalizedMeanAbsoluteErrorValue = "NormalizedMeanAbsoluteError";

        /// <summary> The Spearman&apos;s rank coefficient of correlation is a non-parametric measure of rank correlation. </summary>
        public static ForecastingPrimaryMetrics SpearmanCorrelation { get; } = new ForecastingPrimaryMetrics(SpearmanCorrelationValue);
        /// <summary> The Normalized Root Mean Squared Error (NRMSE) the RMSE facilitates the comparison between models with different scales. </summary>
        public static ForecastingPrimaryMetrics NormalizedRootMeanSquaredError { get; } = new ForecastingPrimaryMetrics(NormalizedRootMeanSquaredErrorValue);
        /// <summary> The R2 score is one of the performance evaluation measures for forecasting-based machine learning models. </summary>
        public static ForecastingPrimaryMetrics R2Score { get; } = new ForecastingPrimaryMetrics(R2ScoreValue);
        /// <summary> The Normalized Mean Absolute Error (NMAE) is a validation metric to compare the Mean Absolute Error (MAE) of (time) series with different scales. </summary>
        public static ForecastingPrimaryMetrics NormalizedMeanAbsoluteError { get; } = new ForecastingPrimaryMetrics(NormalizedMeanAbsoluteErrorValue);
        /// <summary> Determines if two <see cref="ForecastingPrimaryMetrics"/> values are the same. </summary>
        public static bool operator ==(ForecastingPrimaryMetrics left, ForecastingPrimaryMetrics right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ForecastingPrimaryMetrics"/> values are not the same. </summary>
        public static bool operator !=(ForecastingPrimaryMetrics left, ForecastingPrimaryMetrics right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ForecastingPrimaryMetrics"/>. </summary>
        public static implicit operator ForecastingPrimaryMetrics(string value) => new ForecastingPrimaryMetrics(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ForecastingPrimaryMetrics other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ForecastingPrimaryMetrics other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
