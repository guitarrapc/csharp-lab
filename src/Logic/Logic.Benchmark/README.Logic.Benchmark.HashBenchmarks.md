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
| **MD5String**       | **KLVJ(...)0t2z [160]** |     **1,310.2 ns** |      **71.04 ns** |      **3.89 ns** |     **1,306.5 ns** |     **1,314.2 ns** | **0.0134** |    **1128 B** |
| SHA1String      | KLVJ(...)0t2z [160] |     1,471.4 ns |     119.41 ns |      6.55 ns |     1,464.5 ns |     1,477.5 ns | 0.0153 |    1416 B |
| SHA256String    | KLVJ(...)0t2z [160] |     1,720.8 ns |     454.16 ns |     24.89 ns |     1,704.6 ns |     1,749.5 ns | 0.0210 |    1856 B |
| SHA512String    | KLVJ(...)0t2z [160] |     2,884.8 ns |     613.79 ns |     33.64 ns |     2,849.6 ns |     2,916.6 ns | 0.0381 |    3240 B |
| XxHash32String  | KLVJ(...)0t2z [160] |       202.8 ns |      12.98 ns |      0.71 ns |       202.2 ns |       203.6 ns | 0.0069 |     584 B |
| XxHash64String  | KLVJ(...)0t2z [160] |       289.0 ns |      23.79 ns |      1.30 ns |       287.6 ns |       290.2 ns | 0.0086 |     728 B |
| XxHash128String | KLVJ(...)0t2z [160] |       503.6 ns |     152.52 ns |      8.36 ns |       497.9 ns |       513.2 ns | 0.0134 |    1128 B |
| **MD5Binary**       | **Byte[1048576]**       | **1,545,904.3 ns** |   **9,338.78 ns** |    **511.89 ns** | **1,545,474.5 ns** | **1,546,470.6 ns** |      **-** |      **41 B** |
| SHA1Binary      | Byte[1048576]       |   615,112.5 ns |  17,753.31 ns |    973.12 ns |   614,452.4 ns |   616,230.0 ns |      - |      49 B |
| SHA256Binary    | Byte[1048576]       |   655,678.6 ns |  13,672.79 ns |    749.45 ns |   655,238.3 ns |   656,544.0 ns |      - |      57 B |
| SHA512Binary    | Byte[1048576]       | 1,384,415.4 ns | 354,910.49 ns | 19,453.84 ns | 1,372,554.3 ns | 1,406,866.8 ns |      - |      89 B |
| XxHash32Binary  | Byte[1048576]       |   162,373.9 ns |   1,126.55 ns |     61.75 ns |   162,334.3 ns |   162,445.0 ns |      - |      32 B |
| XxHash64Binary  | Byte[1048576]       |    91,888.3 ns |   6,503.75 ns |    356.49 ns |    91,477.4 ns |    92,114.9 ns |      - |      32 B |
| XxHash128Binary | Byte[1048576]       |    65,374.9 ns |   3,423.49 ns |    187.65 ns |    65,222.4 ns |    65,584.5 ns |      - |      40 B |
