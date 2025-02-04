using Logic.Core;

namespace Logic.Tests;

public class HashDataTest
{
    [Theory]
    [InlineData("109287938675324805243", "cadc03f69b24b15315f49d8dcb0e6a11")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "6f96735f150a775f18b550ec05790a8a")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "775088df5ca9ac6f9f1c3e95473aaae8")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "8ac1136b065a091b48a95bfb863fa6c7")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "a18c223883cd27700056d0892cc97391")]
    public void MD5HashDataTest(string contents, string expected)
    {
        var actual = HashData.MD5HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "04acd87b86e2b9eebce9645e6431448ec856b752")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "a4e937f2255a6a8d1399a4ccea620260ca185cc5")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "c0b775c86dbddf44db35cb998f8a97217722737f")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "0ee6120cee6dc21fd02ee60bafa1e22c4930349f")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "056476f5d2ebf792d8831b6b0327054c8b4f3ec1")]
    public void SHA1HashDataTest(string contents, string expected)
    {
        var actual = HashData.SHA1HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "218b6900ef43ef95434e573a77e0e9d94cec887b64408b61d99ec2270a23c4c1")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "5e6da3ad6e460620209b9834057265e03a67eda7399f708f0b0da530a1b8a6c1")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "f35600f390bb76e038bb175bb6e0a3c9c0ec973704b3e306650f5b263ce81c0e")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "628a5d92430db8edee94587ad56910240c432fb125c7d0a92b702cc7e12a6261")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "5a5e1b428bc5135a253eae3af35dd212712ddfe1d0eed0bca60a7799a9d8c3cb")]
    public void SHA256HashDataTest(string contents, string expected)
    {
        var actual = HashData.SHA256HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "849a9bd918f9367e535c5ce5084b23c28c25750fd13f21d97a22f72d895c422f07546b8eaea09144f08e65be855d1999db7f155af91ece0c80d1daac18c4af23")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "2ff91aaa0b8a245c64b6783495a937963e9e9cb366c8d7a876439ca150013acf925245545f3029f3338ca223c5945ddb99e8db965177d9da68aafd0ae8607ccd")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "01978de2a2afa7fef9334fef38d4aa46ad7afe9ebc7859f9bcade36f71a9758996fe26f517796a4c20b1218920934fb565147174526c3ff356bae1254f64f9f5")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "81d300ad21a6ed276ed62698b2cf4c821f10e1cb4bcd355aaef43f81d61b568fddea05239ccfe0fabb511c0c6c76ec324496a1420f2bc191a7915c13fae2f9f5")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "78cb0c4ababeebc793f578dc24f87caf1c82aac45e3d85e5e5bd95421202f165155d8d8bc9c5bf84356c58719dc4e6e7b5d8cd971ddeb32b9c8980e96b75f554")]
    public void SHA512HashDataTest(string contents, string expected)
    {
        var actual = HashData.SHA512HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "010a1131")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "c4d2c10f")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "a8c08e07")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "11a7cef0")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "ccc74c01")]
    public void XxHash32HashDataTest(string contents, string expected)
    {
        var actual = HashData.XxHash32HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "07b8101aa826817d")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "f16314d4c2492edd")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "fc37321efa5befba")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "70e8b70e05558c98")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "f18db63562b4ebf9")]
    public void XxHash64HashDataTest(string contents, string expected)
    {
        var actual = HashData.XxHash64HashData(contents);
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("109287938675324805243", "4156035937c320480382f726231795bd")]
    [InlineData("asdof8ayud9fq84htrq345tq34", "065a424801c3eaf55c86a53fb24e514e")]
    [InlineData("ms0df897yu@3q4t%$&430987yuwreg@[#345gfvdn9", "e036ad8156e27c9059f4c2d33ecb9abd")]
    [InlineData("あ０９８７うｙｓｄｈふぃあｓｄふぁｄｓｆ", "8493b1d704e60952b565e238546f4a2a")]
    [InlineData("kujahsdf@a089u35qSDFASDF()AH$WTあｓｄふぃうｇ９７３８ｒｙ", "e8e682800947f2fe326a9ac2ff27779b")]
    public void XxHash128HashDataTest(string contents, string expected)
    {
        var actual = HashData.XxHash128HashData(contents);
        Assert.Equal(expected, actual);
    }
}
