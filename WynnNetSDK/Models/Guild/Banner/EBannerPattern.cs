using System.Text.Json.Serialization;
using Tavstal.WynnNetSDK.Serialization.Converters;

namespace Tavstal.WynnNetSDK.Models.Guild.Banner;

/// <summary>
/// Represents a pattern that can be applied to a guild banner layer.
/// </summary>
[JsonConverter(typeof(JsonPropertyNameStringEnumConverter<EBannerPattern>))]
public enum EBannerPattern
{
    /// <summary>
    /// The Mojang pattern.
    /// </summary>
    MOJANG,

    /// <summary>
    /// A rhombus in the middle of the banner.
    /// </summary>
    RHOMBUS_MIDDLE,

    /// <summary>
    /// A skull pattern.
    /// </summary>
    SKULL,

    /// <summary>
    /// A square in the bottom-left corner.
    /// </summary>
    SQUARE_BOTTOM_LEFT,

    /// <summary>
    /// A square in the bottom-right corner.
    /// </summary>
    SQUARE_BOTTOM_RIGHT,

    /// <summary>
    /// A square in the top-left corner.
    /// </summary>
    SQUARE_TOP_LEFT,

    /// <summary>
    /// A square in the top-right corner.
    /// </summary>
    SQUARE_TOP_RIGHT,

    /// <summary>
    /// A straight cross pattern.
    /// </summary>
    STRAIGHT_CROSS,

    /// <summary>
    /// A horizontal stripe at the bottom.
    /// </summary>
    STRIPE_BOTTOM,

    /// <summary>
    /// A horizontal stripe in the center.
    /// </summary>
    STRIPE_CENTER,

    /// <summary>
    /// A diagonal stripe going down and to the left.
    /// </summary>
    STRIPE_DOWNLEFT,

    /// <summary>
    /// A diagonal stripe going down and to the right.
    /// </summary>
    STRIPE_DOWNRIGHT,

    /// <summary>
    /// A vertical stripe on the left side.
    /// </summary>
    STRIPE_LEFT,

    /// <summary>
    /// A vertical stripe in the middle.
    /// </summary>
    STRIPE_MIDDLE,

    /// <summary>
    /// A vertical stripe on the right side.
    /// </summary>
    STRIPE_RIGHT,

    /// <summary>
    /// A thin vertical stripe.
    /// </summary>
    STRIPE_SMALL,

    /// <summary>
    /// A horizontal stripe at the top.
    /// </summary>
    STRIPE_TOP,

    /// <summary>
    /// A triangle at the bottom.
    /// </summary>
    TRIANGLE_BOTTOM,

    /// <summary>
    /// A triangle at the top.
    /// </summary>
    TRIANGLE_TOP,

    /// <summary>
    /// Triangles along the bottom edge.
    /// </summary>
    TRIANGLES_BOTTOM,

    /// <summary>
    /// Triangles along the top edge.
    /// </summary>
    TRIANGLES_TOP,

    /// <summary>
    /// The base layer of the banner.
    /// </summary>
    BASE,

    /// <summary>
    /// A blank layer with no pattern.
    /// </summary>
    BLANK,

    /// <summary>
    /// A border around the banner.
    /// </summary>
    BORDER,

    /// <summary>
    /// A brick pattern.
    /// </summary>
    BRICKS,

    /// <summary>
    /// A circle in the middle of the banner.
    /// </summary>
    CIRCLE_MIDDLE,

    /// <summary>
    /// A creeper face pattern.
    /// </summary>
    CREEPER,

    /// <summary>
    /// A diagonal cross pattern.
    /// </summary>
    CROSS,

    /// <summary>
    /// A curly border pattern.
    /// </summary>
    CURLY_BORDER,

    /// <summary>
    /// A diagonal left pattern.
    /// </summary>
    DIAGONAL_LEFT,

    /// <summary>
    /// A mirrored diagonal left pattern.
    /// </summary>
    DIAGONAL_LEFT_MIRROR,

    /// <summary>
    /// A diagonal right pattern.
    /// </summary>
    DIAGONAL_RIGHT,

    /// <summary>
    /// A mirrored diagonal right pattern.
    /// </summary>
    DIAGONAL_RIGHT_MIRROR,

    /// <summary>
    /// A flower pattern.
    /// </summary>
    FLOWER,

    /// <summary>
    /// A gradient that fades downward.
    /// </summary>
    GRADIENT,

    /// <summary>
    /// A gradient that fades upward.
    /// </summary>
    GRADIENT_UP,

    /// <summary>
    /// A horizontal half split.
    /// </summary>
    HALF_HORIZONTAL,

    /// <summary>
    /// A mirrored horizontal half split.
    /// </summary>
    HALF_HORIZONTAL_MIRROR,

    /// <summary>
    /// A vertical half split.
    /// </summary>
    HALF_VERTICAL,

    /// <summary>
    /// A mirrored vertical half split.
    /// </summary>
    HALF_VERTICAL_MIRROR
}
