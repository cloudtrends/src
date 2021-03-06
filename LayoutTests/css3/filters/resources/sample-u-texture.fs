// This test checks that a shader with an unbound sampler is not permitted to execute.
// This shader is not referenced from the CSS mix function and writes its output to gl_FragColor.

precision mediump float;

uniform sampler2D u_texture;

varying vec2 v_texCoord;

void main()
{
	// Try to sample the DOM element texture.
	vec4 color = texture2D(u_texture, v_texCoord);

	// Swap the red and green channels.
	color.rg = color.gr;

	gl_FragColor = color;
}
