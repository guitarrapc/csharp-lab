```

BenchmarkDotNet v0.13.12, Ubuntu 22.04.4 LTS (Jammy Jellyfish)
AMD EPYC 7763, 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.204
  [Host]   : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  ShortRun : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method          | data                | Mean           | Error         | StdDev       | Min            | Max            | Gen0   | Allocated |
|---------------- |-------------------- |---------------:|--------------:|-------------:|---------------:|---------------:|-------:|----------:|
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,338.5 ns** |      **45.75 ns** |      **2.51 ns** |     **1,335.7 ns** |     **1,340.5 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,466.9 ns |     136.51 ns |      7.48 ns |     1,460.9 ns |     1,475.3 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,715.8 ns |     152.48 ns |      8.36 ns |     1,708.9 ns |     1,725.1 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,676.9 ns |     151.19 ns |      8.29 ns |     2,667.9 ns |     2,684.2 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       201.0 ns |      28.44 ns |      1.56 ns |       199.9 ns |       202.8 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       291.3 ns |      85.40 ns |      4.68 ns |       288.6 ns |       296.7 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       474.5 ns |      21.17 ns |      1.16 ns |       473.6 ns |       475.8 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,445.1 ns** |   **4,248.42 ns** |    **232.87 ns** | **1,545,194.1 ns** | **1,545,654.1 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   614,436.1 ns |   5,517.23 ns |    302.42 ns |   614,116.7 ns |   614,718.0 ns |      - |      61 B |
| SHA256Binary    | Byte[1048576]       |   655,871.7 ns |  16,270.64 ns |    891.85 ns |   654,982.1 ns |   656,765.8 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,387,225.7 ns | 383,019.43 ns | 20,994.59 ns | 1,373,170.1 ns | 1,411,359.1 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,176.9 ns |   1,655.73 ns |     90.76 ns |   162,119.8 ns |   162,281.6 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    92,120.8 ns |  24,736.24 ns |  1,355.88 ns |    91,329.0 ns |    93,686.4 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    64,926.6 ns |     275.12 ns |     15.08 ns |    64,910.6 ns |    64,940.5 ns |      - |      40 B |
