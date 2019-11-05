#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// texture samplers
uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // linearly interpolate between both textures (80% container, 20% awesomeface)
//    FragColor = mix(texture(texture1, TexCoord), texture(texture2, vec2(1.0 - TexCoord.x, TexCoord.y)), 0.2);
    
//    FragColor = texture(texture1, TexCoord);
    
    if (TexCoord.x < 0.5 && TexCoord.y < 0.5) {
        FragColor = texture(texture1,TexCoord*2);
    }else if(TexCoord.x > 0.5 && TexCoord.y > 0.5){
        FragColor = texture(texture2,TexCoord*2);
    }else if(TexCoord.x > 0.5 && TexCoord.y < 0.5){
        FragColor = texture(texture1,TexCoord*2);
    }else{
        FragColor = texture(texture2,TexCoord*2);
    }
}
