[代码参考，learnopengl]<https://learnopengl-cn.github.io/01%20Getting%20started/03%20Hello%20Window/>

## xcode工程配置

* 用brew安装glew、glfw

```
 brew install glew
 brew install glfw
```
安装完会显示出安装的目录。

* 用xcode创建一个命令行工程

在build setting 的header search一栏配置加上glew、glfw的include路径

添加library，把上个步骤安装的glew动态库、glfw动态库加进工程。


`另外需要注意的是：mac os 上初始化opengl需要加多一句 glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);`  否则会报glew创建失败的错误

* glad 安装

[下载源码]<http://glad.dav1d.de/generated/tmp5mqhkIglad/?sort_by=size>
[github地址]<>https://github.com/Dav1dde/glad


* glm 安装

`brew install glm`

