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


`另外需要注意的是：mac os 上初始化opengl需要加多一句 glfwWindowHint(GLFW_OPENGL_FORWARD_COMPAT, GL_TRUE);`  
否则会报glew创建失败的错误

* glad 安装

[下载源码](http://glad.dav1d.de/generated/tmp5mqhkIglad/?sort_by=size)

[github地址](https://github.com/Dav1dde/glad)


* glm 安装

`brew install glm`

## 或者直接把glew/glfw/glad 放进相关的目录

把 放入 /usr/local/Cellar目录下

# assimp 安装
模型加载的时候需要用到这个库。
assimp需要自己去下载源文件，然后用cmake make成xcode工程（cmake 点击configure后，会有error，最后再点击genera手动生成xcode文件），然后再用xcode工程编译成动态库。assimp的动态库有依赖绝对路径，所以每个人都要编译一遍。。。